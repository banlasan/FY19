using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc.PageTemplates;

namespace FY19.Models.PageTemplates
{
    public class KMJ_CommonPageProperties : IPageTemplateProperties
    {
        [EditingComponent(CheckBoxComponent.IDENTIFIER, Order = 0, Label = "Show title")]
        public bool ShowTitle { get; set; } = true;
    }
}