using CMS.DocumentEngine;
using Kentico.PageBuilder.Web.Mvc;
using Kentico.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FY19.Controllers
{
    public class RemoteViewController : Controller
    {
        // GET: RemoteView
        public ActionResult Index()
        {
            TreeNode page = DocumentHelper.GetDocuments().Path("/business/service/it-guardians/List-of-services/Remote-view-service-overview").OnCurrentSite().TopN(1).FirstOrDefault();
            if (page == null)
            {
                return HttpNotFound();
            }

            HttpContext.Kentico().PageBuilder().Initialize(page.DocumentID);

            return View();
        }
    }
}