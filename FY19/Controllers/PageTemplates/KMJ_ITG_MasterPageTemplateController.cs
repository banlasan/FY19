using System.Web.Mvc;
using CMS.DocumentEngine.Types.KMJPage;
using FY19.Controllers.PageTemplates;
using FY19.Models.PageTemplates;
using Kentico.PageBuilder.Web.Mvc.PageTemplates;
using CMS.EventLog;

namespace FY19.Controllers.PageTemplates
{
    public class KMJ_ITG_MasterPageTemplateController : PageTemplateController<KMJ_CommonPageProperties>
    {
        public ActionResult Index()
        {
            var KMJ_ITG_MasterPage = GetPage<General>();
            var props = GetProperties();

            EventLogProvider.LogEvent(EventType.INFORMATION, "Template Props", "", eventDescription: "showTitle - " + props.ShowTitle.ToString());

            if (KMJ_ITG_MasterPage == null)
                return HttpNotFound();

            return View("PageTemplates/KMJ_ITG_MasterPageView", KMJ_CommonPageTemplateViewModel.GetViewModel(KMJ_ITG_MasterPage, props));
        }
    }
}