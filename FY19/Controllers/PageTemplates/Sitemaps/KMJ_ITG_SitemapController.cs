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

[assembly: RegisterPageTemplate("FY19.KMJ_ITG_Sitemap", typeof(KMJ_ITG_SitemapController), "KMJ ITG Sitemap", Description = "-", IconClass = "icon-doc-o")]

namespace FY19.Controllers.PageTemplates
{
    public class KMJ_ITG_SitemapController : PageTemplateController<KMJ_CommonPageProperties>
    {
        public ActionResult Index()
        {
            var KMJ_ITG_Sitemap = GetPage<General>();
            var props = GetProperties();

            EventLogProvider.LogEvent(EventType.INFORMATION, "Template Props", "", eventDescription: "showTitle - " + props.ShowTitle.ToString());

            if (KMJ_ITG_Sitemap == null)
                return HttpNotFound();

            return View("PageTemplates/Sitemaps/KMJ_ITG_Sitemap", KMJ_CommonPageTemplateViewModel.GetViewModel(KMJ_ITG_Sitemap, props));
        }
    }
}