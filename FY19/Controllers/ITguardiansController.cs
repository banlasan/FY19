using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CMS.DocumentEngine;
using Kentico.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;
using CMS.EventLog;
using CMS.MacroEngine;
using CMS.SiteProvider;
using System.Data;
using CMS.DataEngine;
using FY19.Repositories;
using FY19.Infrastructure;
using CMS.DocumentEngine.Types.KMJPage;
using Kentico.PageBuilder.Web.Mvc.PageTemplates;

namespace FY19.Controllers
{
    public class ITguardiansController : Controller
    {

        private readonly IKMJPageGeneralRepository kmjRepository;
        private readonly IOutputCacheDependencies mOutputCacheDependencies;

        public ITguardiansController(IKMJPageGeneralRepository repository, IOutputCacheDependencies outputCacheDependencies)
        {
            kmjRepository = repository;
            mOutputCacheDependencies = outputCacheDependencies;
        }

        // GET: ITguardians
        public ActionResult Index()
        {
            //EventLogProvider.LogEvent(EventType.INFORMATION, "Entering ITguardiansController", "", eventDescription: "Success");

            //var text = DocumentHelper.GetDocuments("KMJPage.General")
            //.Path("/business/service/it-guardians/Home")
            //.OnCurrentSite().FirstOrDefault().GetOriginalValue("Text");

            //DocumentQuery pages = new DocumentQuery()
            //    .Path(MacroResolver.ResolveCurrentPath("/"), PathTypeEnum.Section)
            //    .OnSite(SiteContext.CurrentSiteName);

            //TreeNode page = DocumentHelper.GetDocuments()
            //.Path("/business/service/it-guardians/Home")
            //.WhereEquals("NodeAlias", "Home")
            //.OnCurrentSite()
            //.TopN(1)
            //.FirstOrDefault();

            //HttpContext.Kentico().PageBuilder().Initialize(page.DocumentID);

            //ViewBag.Text = text.ToString();
            //return View(page.DocumentID);

            var KMJGeneral = kmjRepository.GetGeneral();

            if (KMJGeneral == null)
                return HttpNotFound();

            EventLogProvider.LogEvent(EventType.INFORMATION, "KMJ General", "", eventDescription: "document id - " + KMJGeneral.DocumentID);

            HttpContext.Kentico().PageBuilder().Initialize(KMJGeneral.DocumentID);

            mOutputCacheDependencies.AddDependencyOnPage<General>(KMJGeneral.DocumentID);

            return new TemplateResult(KMJGeneral.DocumentID);
        }
    }
}
