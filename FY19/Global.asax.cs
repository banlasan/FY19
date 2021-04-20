using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using CMS.AspNet.Platform;
using CMS.ContactManagement;
using FY19.PageTemplateFilters;
using Kentico.OnlineMarketing.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;
using Kentico.Web.Mvc;

namespace FY19
{
    public class FY19Application : HttpApplication
    {
        protected void Application_Start()
        {
            // Enables and configures selected Kentico ASP.NET MVC integration features
            ApplicationConfig.RegisterFeatures(ApplicationBuilder.Current);

            // Registers routes including system routes for enabled features
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            // Registers enabled bundles
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            DependencyResolverConfig.Register();

            //RegisterPageTemplateFilters();
        }

        public override string GetVaryByCustomString(HttpContext context, string custom)
        {
            var options = OutputCacheKeyHelper.CreateOptions();
            var contactGroupKey = String.Empty;

            switch (custom)
            {
                case "DefaultProfile":
                    options
                        .VaryByUser()
                        .VaryByHost()
                        .VaryByCookieLevel();
                    break;

                case "PageBuilderProfile":
                    options
                        .VaryByUser()
                        .VaryByHost()
                        .VaryByPersona()
                        .VaryByABTestVariant()
                        .VaryByCookieLevel();

                    contactGroupKey = GetContactGroupCacheKey();
                    break;
            }

            // Get cache key generated based on cache options
            var builtCacheKey = OutputCacheKeyHelper.GetVaryByCustomString(context, custom, options);

            // Combine cache options with custom contact group cache key if exists
            if (!String.IsNullOrEmpty(contactGroupKey))
            {
                builtCacheKey = String.Join("|", builtCacheKey, contactGroupKey);
            }

            if (!String.IsNullOrEmpty(builtCacheKey))
            {
                return builtCacheKey;
            }

            return base.GetVaryByCustomString(context, custom);
        }


        /// <summary>
        /// Gets the cache key with current contant contact groups
        /// </summary>
        private string GetContactGroupCacheKey()
        {
            // Gets the current contact, without creating a new anonymous contact for new visitors
            var existingContact = ContactManagementContext.GetCurrentContact(createAnonymous: false);
            var groupsKey = String.Empty;

            if (existingContact != null)
            {
                var groups = existingContact?.ContactGroups?.Select(x => x.ContactGroupID).OrderBy(x => x).ToArray() ?? new int[] { };
                groupsKey = String.Join(";", groups);
            }

            return $"ContactGroup={groupsKey}";
        }

        protected void Application_Error()
        {
            ApplicationErrorLogger.LogLastApplicationError();
            Handle404Error();
        }
        private void Handle404Error()
        {
            var error = Server.GetLastError();
            if ((error as HttpException)?.GetHttpCode() == 404)
            {
                Server.ClearError();
                Response.StatusCode = 404;
            }
        }

        private void RegisterPageTemplateFilters()
        {
            //PageBuilderFilters.PageTemplates.Add(new KMJ_GenericPageTemplateFilter());
            //PageBuilderFilters.PageTemplates.Add(new KMJ_CatalogDownloadPageTemplateFilter());
        }
    }
}
