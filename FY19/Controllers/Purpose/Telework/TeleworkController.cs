using CMS.DocumentEngine;
using Kentico.PageBuilder.Web.Mvc;
using Kentico.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FY19.Controllers.Purpose.Telework
{
    public class TeleworkController : Controller
    {
        // GET: Telework
        public ActionResult Index()
        {
            TreeNode page = DocumentHelper.GetDocuments().Path("/business/service/it-guardians/Problem-Solving/Improving-productivity-through-information-transmi").OnCurrentSite().TopN(1).FirstOrDefault();
            if (page == null)
            {
                return HttpNotFound();
            }

            HttpContext.Kentico().PageBuilder().Initialize(page.DocumentID);

            return View();
        }
    }
}