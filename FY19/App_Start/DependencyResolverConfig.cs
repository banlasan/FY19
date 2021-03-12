using Autofac;
using Autofac.Extras.DynamicProxy2;
using Autofac.Integration.Mvc;
using FY19.Infrastructure;
using FY19.Repositories;
using Kentico.Content.Web.Mvc;
using Kentico.Web.Mvc;
using System;
using System.Configuration;
using System.Globalization;
using System.Web;
using System.Web.Mvc;

namespace FY19
{
    public class DependencyResolverConfig
    {

        public static void Register()
        {
            var builder = new ContainerBuilder();

            ConfigureDependencyResolverForMvcApplication(builder);

            AttachCMSDependencyResolver(builder);

            DependencyResolver.SetResolver(new AutofacDependencyResolver(builder.Build()));
        }

        private static void ConfigureDependencyResolverForMvcApplication(ContainerBuilder builder)
        {
            // Enable property injection in view pages
            builder.RegisterSource(new ViewRegistrationSource());

            // Register web abstraction classes
            builder.RegisterModule<AutofacWebTypesModule>();

            // Register controllers
            builder.RegisterControllers(typeof(FY19Application).Assembly);

            // Register repositories
            builder.RegisterAssemblyTypes(typeof(FY19Application).Assembly)
                .Where(x => x.IsClass && !x.IsAbstract && typeof(IRepository).IsAssignableFrom(x))
                .AsImplementedInterfaces()
                .WithParameter((parameter, context) => parameter.Name == "cultureName", (parameter, context) => CultureInfo.CurrentUICulture.Name)
                .WithParameter((parameter, context) => parameter.Name == "latestVersionEnabled", (parameter, context) => IsPreviewEnabled())
                //.EnableInterfaceInterceptors().InterceptedBy(typeof(CachingRepositoryDecorator))
                .InstancePerRequest();


            // Register providers of additional information about content items
            builder.RegisterType<ContentItemMetadataProvider>()
                .AsImplementedInterfaces()
                .SingleInstance();

            // Register caching decorator for repositories
            //builder.Register(context => new CachingRepositoryDecorator(GetCacheItemDuration(), context.Resolve<IContentItemMetadataProvider>(), IsCacheEnabled()))
            //    .InstancePerRequest();

            // Enable declaration of output cache dependencies in controllers
            builder.Register(context => new OutputCacheDependencies(context.Resolve<HttpResponseBase>(), context.Resolve<IContentItemMetadataProvider>(), IsCacheEnabled()))
                .AsImplementedInterfaces()
                .InstancePerRequest();
        }

        private static void AttachCMSDependencyResolver(ContainerBuilder builder)
        {
            builder.RegisterSource(new CMSRegistrationSource());
        }

        private static bool IsCacheEnabled()
        {
            return !IsPreviewEnabled();
        }


        private static bool IsPreviewEnabled()
        {
            return HttpContext.Current.Kentico().Preview().Enabled;
        }

        private static TimeSpan GetCacheItemDuration()
        {
            var value = ConfigurationManager.AppSettings["RepositoryCacheItemDuration"];
            var seconds = 0;

            if (Int32.TryParse(value, NumberStyles.Integer, CultureInfo.InvariantCulture, out seconds) && seconds > 0)
            {
                return TimeSpan.FromSeconds(seconds);
            }

            return TimeSpan.Zero;
        }

    }
}