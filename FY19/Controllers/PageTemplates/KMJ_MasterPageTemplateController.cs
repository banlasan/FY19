using System.Web.Mvc;
using CMS.DocumentEngine.Types.KMJPage;
using FY19.Controllers.PageTemplates;
using FY19.Models.PageTemplates;
using Kentico.PageBuilder.Web.Mvc.PageTemplates;
using CMS.EventLog;

[assembly: RegisterPageTemplate("FY19.KMJ_MasterPage", typeof(KMJ_MasterPageTemplateController), "Master Page Template", Description = "-", IconClass = "icon-doc-o")]

namespace FY19.Controllers.PageTemplates
{
    public class KMJ_MasterPageTemplateController : PageTemplateController<KMJ_CommonPageProperties>
    {
        public ActionResult Index()
        {
            var KMJ_MasterPage = GetPage<General>();
            var props = GetProperties();

            EventLogProvider.LogEvent(EventType.INFORMATION, "Template Props", "", eventDescription: "showTitle - " + props.ShowTitle.ToString());

            if (KMJ_MasterPage == null)
                return HttpNotFound();

            return View("PageTemplates/KMJ_MasterPageView", KMJ_CommonPageTemplateViewModel.GetViewModel(KMJ_MasterPage, props));
        }
    }
}