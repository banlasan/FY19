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
    public class SystemController : Controller
    {
        // GET: System
        public ActionResult Index()
        {
            TreeNode page = DocumentHelper.GetDocuments().Path("/business/service/it-guardians/Problem-Solving/Reducing-the-operational-load-on-information-syste").OnCurrentSite().TopN(1).FirstOrDefault();
            if (page == null)
            {
                return HttpNotFound();
            }

            HttpContext.Kentico().PageBuilder().Initialize(page.DocumentID);

            return View();
        }
    }
}