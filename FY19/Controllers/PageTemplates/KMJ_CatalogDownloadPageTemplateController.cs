using CMS.DocumentEngine.Types.KMJPage;
using CMS.EventLog;
using FY19.Controllers.PageTemplates;
using FY19.Models.PageTemplates;
using Kentico.PageBuilder.Web.Mvc.PageTemplates;
using System.Web.Mvc;

[assembly: RegisterPageTemplate("FY19.KMJ_Office365MasterPage", typeof(KMJ_CatalogDownloadPageTemplateController), "Catalog Download Page Template", Description = "-", IconClass = "icon-doc-o")]

namespace FY19.Controllers.PageTemplates
{
    public class KMJ_CatalogDownloadPageTemplateController : PageTemplateController<KMJ_CommonPageProperties>
    {
        public ActionResult Index()
        {
            var KMJ_CatalogDownloadPage = GetPage<General>();
            var props = GetProperties();

            EventLogProvider.LogEvent(EventType.INFORMATION, "Template Props", "", eventDescription: "showTitle - " + props.ShowTitle.ToString());

            if (KMJ_CatalogDownloadPage == null)
                return HttpNotFound();

            return View("PageTemplates/KMJ_CatalogDownloadView", KMJ_CommonPageTemplateViewModel.GetViewModel(KMJ_CatalogDownloadPage, props));
        }
    }
}