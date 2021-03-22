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

[assembly: RegisterPageTemplate("FY19.KMJ_Document_Sitemap", typeof(KMJ_Document_SitemapController), "KMJ Document Sitemap", Description = "-", IconClass = "icon-doc-o")]

namespace FY19.Controllers.PageTemplates
{
    public class KMJ_Document_SitemapController : PageTemplateController<KMJ_CommonPageProperties>
    {
        // GET: KMJ_Document_Sitemap
        public ActionResult Index()
        {
            var KMJ_Document_Sitemap = GetPage<General>();
            var props = GetProperties();

            EventLogProvider.LogEvent(EventType.INFORMATION, "Template Props", "", eventDescription: "showTitle - " + props.ShowTitle.ToString());

            if (KMJ_Document_Sitemap == null)
                return HttpNotFound();

            return View("PageTemplates/Sitemaps/KMJ_DocumentSitemap", KMJ_CommonPageTemplateViewModel.GetViewModel(KMJ_Document_Sitemap, props));
        }
    }
}