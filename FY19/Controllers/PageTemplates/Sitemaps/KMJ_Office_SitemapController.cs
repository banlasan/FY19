using CMS.DocumentEngine.Types.KMJPage;
using CMS.EventLog;
using FY19.Controllers.PageTemplates;
using FY19.Models.PageTemplates;
using Kentico.PageBuilder.Web.Mvc.PageTemplates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FY19.Controllers.PageTemplates
{
    public class KMJ_Office_SitemapController : PageTemplateController<KMJ_CommonPageProperties>
    {
        // GET: KMJ_Office_Sitemap
        public ActionResult Index()
        {
            var KMJ_Office_Sitemap = GetPage<General>();
            var props = GetProperties();

            EventLogProvider.LogEvent(EventType.INFORMATION, "Template Props", "", eventDescription: "showTitle - " + props.ShowTitle.ToString());

            if (KMJ_Office_Sitemap == null)
                return HttpNotFound();

            return View("PageTemplates/Sitemaps/KMJ_OfficeSitemap", KMJ_CommonPageTemplateViewModel.GetViewModel(KMJ_Office_Sitemap, props));
        }
    }
}