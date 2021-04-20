using System.Web.Mvc;
using CMS.DocumentEngine.Types.KMJPage;
using FY19.Controllers.PageTemplates;
using FY19.Models.PageTemplates;
using Kentico.PageBuilder.Web.Mvc.PageTemplates;
using CMS.EventLog;

namespace FY19.Controllers.PageTemplates
{
    public class KMJ_GenericWidgetPageTemplateController : PageTemplateController<KMJ_CommonPageProperties>
    {
        public ActionResult Index()
        {
            var KMJ_GenericWidgetPage = GetPage<General>();
            var props = GetProperties();

            EventLogProvider.LogEvent(EventType.INFORMATION, "Template Props", "", eventDescription: "showTitle - " + props.ShowTitle.ToString());

            if (KMJ_GenericWidgetPage == null)
                return HttpNotFound();

            return View("PageTemplates/KMJ_GenericWidgetPageView", KMJ_CommonPageTemplateViewModel.GetViewModel(KMJ_GenericWidgetPage, props));
        }
    }
}