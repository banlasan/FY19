using System.Web;
using System.Web.Optimization;

namespace FY19
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        //public static void RegisterBundles(BundleCollection bundles)
        //{
        //    // Custom JavaScript files from the ~/Scripts/ directory can be included as well
        //    bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
        //                "~/Scripts/site.js"));

        //    // Custom CSS files from the ~/Content/ directory can be included as well
        //    bundles.Add(new StyleBundle("~/Content/css").Include(
        //                "~/Content/site.css"));
        //}
        public static void RegisterBundles(BundleCollection bundles)
        {
            // Custom JavaScript files from the ~/Scripts/ directory can be included as well
            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                        "~/Scripts/jquery-3.5.1.min.js",
                        "~/Scripts/index.js",
                        "~/Scripts/jquery-smoothscroll.js"));

            // Custom CSS files from the ~/Content/ directory can be included as well
            bundles.Add(new StyleBundle("~/Content/css").Include(
                        "~/Content/it-guardians.css",
                        "~/Content/it-guardians_top.css",
                        "~/Content/responsive.css"));

            BundleTable.EnableOptimizations = true;
        }
    }
}