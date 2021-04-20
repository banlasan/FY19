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
    public class KMJ_GenericPageTemplateController : PageTemplateController<KMJ_CommonPageProperties>
    {
        public ActionResult Index()
        {
            var KMJ_GenericPage = GetPage<General>();
            var props = GetProperties();

            EventLogProvider.LogEvent(EventType.INFORMATION, "Template Props for KMJ_GenericPageTemplateController", "", eventDescription: "showTitle - " + props.ShowTitle.ToString());

            if (KMJ_GenericPage == null)
                return HttpNotFound();

            return View("PageTemplates/KMJ_GenericPageView", KMJ_CommonPageTemplateViewModel.GetViewModel(KMJ_GenericPage, props));
        }
    }
}