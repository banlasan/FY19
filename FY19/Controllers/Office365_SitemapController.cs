using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CMS.DocumentEngine;

using Kentico.PageBuilder.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc.PageTemplates;
using Kentico.Web.Mvc;
using KMVCHelper;

namespace FY19.Controllers
{
    [KMVCRouteOverPathPriority]
    public class Office365_SitemapController : PageTemplateController
    {
        // GET: Office365_Sitemap
        public ActionResult Index()
        {
            TreeNode page = DocumentHelper.GetDocuments().Path("/business/solution/innovation/collaboration_work/Office365_Sitemap").OnCurrentSite().TopN(1).FirstOrDefault();
            if (page == null)
            {
                return HttpNotFound();
            }

            HttpContext.Kentico().PageBuilder().Initialize(page.DocumentID);

            // Use template if it has one.
            if (KMVCDynamicHttpHandler.PageHasTemplate(page))
            {
                return new TemplateResult(page.DocumentID);
            }
            else
            {
                return View();
            }
        }
    }
}