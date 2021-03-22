using System.Web.Mvc;
using CMS.DocumentEngine.Types.KMJPage;
using FY19.Controllers.PageTemplates;
using FY19.Models.PageTemplates;
using Kentico.PageBuilder.Web.Mvc.PageTemplates;
using CMS.EventLog;

[assembly: RegisterPageTemplate("FY19.KMJ_GenericCategoryTopPage", typeof(KMJ_GenericCategoryTopPageTemplateController), "Generic Category Top Page Template", Description = "-", IconClass = "icon-doc-o")]

namespace FY19.Controllers.PageTemplates
{
    public class KMJ_GenericCategoryTopPageTemplateController : PageTemplateController<KMJ_CommonPageProperties>
    {
        public ActionResult Index()
        {
            var KMJ_GenericCategoryTopPage = GetPage<General>();
            var props = GetProperties();

            EventLogProvider.LogEvent(EventType.INFORMATION, "Template Props", "", eventDescription: "showTitle - " + props.ShowTitle.ToString());

            if (KMJ_GenericCategoryTopPage == null)
                return HttpNotFound();

            return View("PageTemplates/KMJ_GenericCategoryTopView", KMJ_CommonPageTemplateViewModel.GetViewModel(KMJ_GenericCategoryTopPage, props));
        }
    }
}