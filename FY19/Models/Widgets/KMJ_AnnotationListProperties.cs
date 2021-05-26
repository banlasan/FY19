using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace FY19.Models.Widgets
{
    public class KMJ_AnnotationListProperties : IWidgetProperties
    {
        [EditingComponent(RadioButtonsComponent.IDENTIFIER, Order = 0, Label = "Count")]
        [EditingComponentProperty(nameof(RadioButtonsProperties.DataSource), "With;with\r\nNone;none")]
        [StringLength(200, ErrorMessage = "Limit 200 characters")]
        public string Count { get; set; } = "None";

        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 1, Label = "Text 1")]
        [StringLength(1000, ErrorMessage = "Limit 1000 characters")]
        public string Text1 { get; set; }

        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 2, Label = "Text 2")]
        [StringLength(1000, ErrorMessage = "Limit 1000 characters")]
        public string Text2 { get; set; }

        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 3, Label = "Text 3")]
        [StringLength(1000, ErrorMessage = "Limit 1000 characters")]
        public string Text3 { get; set; }

        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 4, Label = "Text 4")]
        [StringLength(1000, ErrorMessage = "Limit 1000 characters")]
        public string Text4 { get; set; }

        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 5, Label = "Text 5")]
        [StringLength(1000, ErrorMessage = "Limit 1000 characters")]
        public string Text5 { get; set; }

        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 6, Label = "Text 6")]
        [StringLength(1000, ErrorMessage = "Limit 1000 characters")]
        public string Text6 { get; set; }

        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 7, Label = "Text 7")]
        [StringLength(1000, ErrorMessage = "Limit 1000 characters")]
        public string Text7 { get; set; }

        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 8, Label = "Text 8")]
        [StringLength(1000, ErrorMessage = "Limit 1000 characters")]
        public string Text8 { get; set; }

        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 9, Label = "Text 9")]
        [StringLength(1000, ErrorMessage = "Limit 1000 characters")]
        public string Text9 { get; set; }

        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 10, Label = "Text 10")]
        [StringLength(1000, ErrorMessage = "Limit 1000 characters")]
        public string Text10 { get; set; }

        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 11, Label = "Id")]
        [StringLength(200, ErrorMessage = "Limit 200 characters")]
        [RegularExpression(@"^\S*$", ErrorMessage = "No white space allowed")]
        public string Id { get; set; }

        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 12, Label = "Class")]
        [StringLength(200, ErrorMessage = "Limit 200 characters")]
        public string Class { get; set; }
    }
}