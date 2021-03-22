﻿using System.Web.Mvc;
using CMS.DocumentEngine.Types.KMJPage;
using FY19.Controllers.PageTemplates;
using FY19.Models.PageTemplates;
using Kentico.PageBuilder.Web.Mvc.PageTemplates;
using CMS.EventLog;

[assembly: RegisterPageTemplate("FY19.KMJ_OfficeMasterPage", typeof(KMJ_OfficeMasterPageTemplateController), "Office 365 Master Page Template", Description = "-", IconClass = "icon-doc-o")]

namespace FY19.Controllers.PageTemplates
{
    public class KMJ_OfficeMasterPageTemplateController : PageTemplateController<KMJ_CommonPageProperties>
    {
        public ActionResult Index()
        {
            var KMJ_OfficeMasterPage = GetPage<General>();
            var props = GetProperties();

            EventLogProvider.LogEvent(EventType.INFORMATION, "Template Props", "", eventDescription: "showTitle - " + props.ShowTitle.ToString());

            if (KMJ_OfficeMasterPage == null)
                return HttpNotFound();

            return View("PageTemplates/KMJ_OfficeMasterPageView", KMJ_CommonPageTemplateViewModel.GetViewModel(KMJ_OfficeMasterPage, props));
        }
    }
}