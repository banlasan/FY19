using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;

namespace FY19.Models.Sections
{
    public class IndexSectionProperties : ISectionProperties
    {
        [EditingComponent(DropDownComponent.IDENTIFIER, Order = 0, Label = "Select Class")]
        [EditingComponentProperty(nameof(DropDownProperties.DataSource), "index-section-01;Index Section 1\r\nindex-section-02;Index Section 2")]
        public string Class { get; set; } = "index-section-01";
    }
}