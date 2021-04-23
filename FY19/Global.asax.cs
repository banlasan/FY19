using System;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using CMS.AspNet.Platform;
using CMS.ContactManagement;
using Kentico.OnlineMarketing.Web.Mvc;
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
        }
    }
}
