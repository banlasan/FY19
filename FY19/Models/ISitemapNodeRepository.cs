using System.Web.Mvc;

namespace FY19.Models
{
    interface ISitemapNodeRepository
    {
        string SetSitemapNodes(UrlHelper urlHelper, string path);
    }
}