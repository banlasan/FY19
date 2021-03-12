using Kentico.PageBuilder.Web.Mvc;
using System.Web.Mvc;

namespace FY19.Controllers.Sections
{
    public class SingleColumnSection : SectionController
    {
        public ActionResult Index()
        {
            return PartialView("Sections/SingleColumnView");
        }
    }
}