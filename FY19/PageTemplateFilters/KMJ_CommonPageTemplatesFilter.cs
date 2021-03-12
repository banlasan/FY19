using Kentico.PageBuilder.Web.Mvc.PageTemplates;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FY19.PageTemplateFilters
{
    public class KMJ_CommonPageTemplatesFilter : IPageTemplateFilter
    {
        public IEnumerable<PageTemplateDefinition> Filter(IEnumerable<PageTemplateDefinition> pageTemplates, PageTemplateFilterContext context)
        {
            if (context.PageType.Equals("FY19.KMJ_CommonPage", StringComparison.InvariantCultureIgnoreCase))
            {
                return pageTemplates.Where(t => GetCommonPageTemplates().Contains(t.Identifier));
            }

            // Exclude all article page templates from the final collection if the context does not match this filter
            return pageTemplates.Where(t => !GetCommonPageTemplates().Contains(t.Identifier));
        }

        public IEnumerable<string> GetCommonPageTemplates() => new string[] { "FY19.KMJ_CommonPage" };
    }
}