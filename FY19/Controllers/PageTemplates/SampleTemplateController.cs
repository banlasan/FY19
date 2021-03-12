using CMS.DocumentEngine.Types.KMJPage;
using CMS.EventLog;
using FY19.Models.PageTemplates;
using Kentico.PageBuilder.Web.Mvc.PageTemplates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FY19.Controllers.PageTemplates
{
    public class SampleTemplateController : PageTemplateController<KMJ_CommonPageProperties>
    {
        public ActionResult Index()
        {
            var sampleTemplatePage = GetPage<General>();
            var props = GetProperties();

            EventLogProvider.LogEvent(EventType.INFORMATION, "Template Props", "", eventDescription: "showTitle - " + props.ShowTitle.ToString());

            if (sampleTemplatePage == null)
                return HttpNotFound();

            return View("PageTemplates/SampleTemplateView", KMJ_CommonPageTemplateViewModel.GetViewModel(sampleTemplatePage, props));
        }
    }
}