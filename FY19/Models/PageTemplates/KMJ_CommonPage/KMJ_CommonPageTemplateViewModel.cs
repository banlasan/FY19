using CMS.DocumentEngine.Types.KMJPage;
using Kentico.PageBuilder.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc.PageTemplates;

namespace FY19.Models.PageTemplates
{
    public class KMJ_CommonPageTemplateViewModel
    {
        public string OgImage { get; set; }

        public string Text { get; set; }

        public KMJ_CommonPageProperties props { get; set; }

        public static KMJ_CommonPageTemplateViewModel GetViewModel(General general, KMJ_CommonPageProperties props)
        {
            return new KMJ_CommonPageTemplateViewModel
            {
                OgImage = general.OgImage,
                Text = general.Text,
                props = props
            };
        }

        public string Html { get; set; }
    }
}