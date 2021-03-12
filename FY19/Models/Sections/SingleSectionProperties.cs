using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;

namespace FY19.Models.Sections
{
    public class SingleSectionProperties : ISectionProperties
    {
        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 0, Label = "Color")]
        public string Color { get; set; } = "#4a2626";
    }
}