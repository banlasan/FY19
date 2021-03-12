using System.Collections.Generic;

namespace FY19.Models.Widgets
{
    public class BreadCrumbsViewModel
    {
        public IList<BreadCrumbsPaths> PathTitle { get; set; }
        public string ContentBefore { get; set; }
        public string ContentAfter { get; set; }
    }
}