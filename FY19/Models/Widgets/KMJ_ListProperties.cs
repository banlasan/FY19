using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FY19.Models.Widgets
{
    public class KMJ_ListProperties : IWidgetProperties
    {
        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 11, Label = "Id")]
        [StringLength(1000, ErrorMessage = "Limit 1000 characters")]
        [RegularExpression(@"^\S*$", ErrorMessage = "No white space allowed")]
        public string Id { get; set; }

        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 10, Label = "Class")]
        [StringLength(1000, ErrorMessage = "Limit 1000 characters")]
        public string Class { get; set; }

        [EditingComponent(TextAreaComponent.IDENTIFIER, Order = 0, Label = "Text 1")]
        [EditingComponentProperty(nameof(TextAreaProperties.Name), "")]
        [StringLength(1000, ErrorMessage = "Limit 1000 characters")]
        [Required]
        public string Text1 { get; set; }

        [EditingComponent(TextAreaComponent.IDENTIFIER, Order = 1, Label = "Text 2")]
        [EditingComponentProperty(nameof(TextAreaProperties.Name), "")]
        [StringLength(1000, ErrorMessage = "Limit 1000 characters")]
      //  [Required]
        public string Text2 { get; set; }

        [EditingComponent(TextAreaComponent.IDENTIFIER, Order = 2, Label = "Text 3")]
        [EditingComponentProperty(nameof(TextAreaProperties.Name), "")]
        [StringLength(1000, ErrorMessage = "Limit 1000 characters")]
       // [Required]
        public string Text3 { get; set; }

        [EditingComponent(TextAreaComponent.IDENTIFIER, Order = 3, Label = "Text 4")]
        [EditingComponentProperty(nameof(TextAreaProperties.Name), "")]
        [StringLength(1000, ErrorMessage = "Limit 1000 characters")]
        //[Required]
        public string Text4 { get; set; }

        [EditingComponent(TextAreaComponent.IDENTIFIER, Order = 4, Label = "Text 5")]
        [EditingComponentProperty(nameof(TextAreaProperties.Name), "")]
        [StringLength(1000, ErrorMessage = "Limit 1000 characters")]
      //  [Required]
        public string Text5 { get; set; }

        [EditingComponent(TextAreaComponent.IDENTIFIER, Order = 5, Label = "Text 6")]
        [EditingComponentProperty(nameof(TextAreaProperties.Name), "")]
        [StringLength(1000, ErrorMessage = "Limit 1000 characters")]
      //  [Required]
        public string Text6 { get; set; }

        [EditingComponent(TextAreaComponent.IDENTIFIER, Order = 6, Label = "Text 7")]
        [EditingComponentProperty(nameof(TextAreaProperties.Name), "")]
        [StringLength(1000, ErrorMessage = "Limit 1000 characters")]
       // [Required]
        public string Text7 { get; set; }

        [EditingComponent(TextAreaComponent.IDENTIFIER, Order = 7, Label = "Text 8")]
        [EditingComponentProperty(nameof(TextAreaProperties.Name), "")]
        [StringLength(1000, ErrorMessage = "Limit 1000 characters")]
       // [Required]
        public string Text8 { get; set; }

        [EditingComponent(TextAreaComponent.IDENTIFIER, Order = 8, Label = "Text 9")]
        [EditingComponentProperty(nameof(TextAreaProperties.Name), "")]
        [StringLength(1000, ErrorMessage = "Limit 1000 characters")]
       // [Required]
        public string Text9 { get; set; }

        [EditingComponent(TextAreaComponent.IDENTIFIER, Order = 9, Label = "Text 10")]
        [EditingComponentProperty(nameof(TextAreaProperties.Name), "")]
        [StringLength(1000, ErrorMessage = "Limit 1000 characters")]
       // [Required]
        public string Text10 { get; set; }
    }
}