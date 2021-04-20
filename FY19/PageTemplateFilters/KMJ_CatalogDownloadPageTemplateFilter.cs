using Kentico.PageBuilder.Web.Mvc.PageTemplates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FY19.PageTemplateFilters
{
    //public class KMJ_CatalogDownloadPageTemplateFilter : IPageTemplateFilter
    //{
    //    public IEnumerable<PageTemplateDefinition> Filter(IEnumerable<PageTemplateDefinition> pageTemplates, PageTemplateFilterContext context)
    //    {
    //        if (context.PageType.Equals("FY19.KMJ_CatalogDownloadPage", StringComparison.InvariantCultureIgnoreCase))
    //        {
    //            return pageTemplates.Where(t => GetPageTemplates().Contains(t.Identifier));
    //        }

    //        // Exclude all article page templates from the final collection if the context does not match this filter
    //        return pageTemplates.Where(t => !GetPageTemplates().Contains(t.Identifier));
    //    }

    //    public IEnumerable<string> GetPageTemplates() => new string[] { "FY19.KMJ_CatalogDownloadPage" };
    //}
}