using FY19.Helpers;
using System.Web.Mvc;

namespace FY19.Models
{
    public class SitemapNodeRepository : ISitemapNodeRepository
    {
        public string SetSitemapNodes(UrlHelper urlHelper, string path)
        {
            return clsSitemap.SetSitemap(urlHelper, path);
        }
    }
}