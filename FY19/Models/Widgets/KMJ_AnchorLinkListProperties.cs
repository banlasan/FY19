using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FY19.Models.Widgets
{
    public class KMJ_AnchorLinkListProperties : IWidgetProperties
    {
        [EditingComponent(TextAreaComponent.IDENTIFIER, Order = 0, Label = "Link 1 text")]
        [EditingComponentProperty(nameof(TextAreaProperties.Name), "")]
        [StringLength(1000, ErrorMessage = "Limit 200 characters")]
        public string Text1 { get; set; }
        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 1, Label = "Link 1 URL")]
        [EditingComponentProperty(nameof(TextAreaProperties.Name), "")]
        [StringLength(1000, ErrorMessage = "Limit 1000 characters")]
        public string Url1 { get; set; }

        [EditingComponent(TextAreaComponent.IDENTIFIER, Order = 2, Label = "Link 2 text")]
        [EditingComponentProperty(nameof(TextAreaProperties.Name), "")]
        [StringLength(1000, ErrorMessage = "Limit 200 characters")]
        public string Text2 { get; set; }
        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 3, Label = "Link 2 URL")]
        [EditingComponentProperty(nameof(TextAreaProperties.Name), "")]
        [StringLength(1000, ErrorMessage = "Limit 1000 characters")]
        public string Url2 { get; set; }

        [EditingComponent(TextAreaComponent.IDENTIFIER, Order = 4, Label = "Link 3 text")]
        [EditingComponentProperty(nameof(TextAreaProperties.Name), "")]
        [StringLength(1000, ErrorMessage = "Limit 200 characters")]
        public string Text3 { get; set; }
        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 5, Label = "Link 3 URL")]
        [EditingComponentProperty(nameof(TextAreaProperties.Name), "")]
        [StringLength(1000, ErrorMessage = "Limit 1000 characters")]
        public string Url3 { get; set; }

        [EditingComponent(TextAreaComponent.IDENTIFIER, Order = 6, Label = "Link 4 text")]
        [EditingComponentProperty(nameof(TextAreaProperties.Name), "")]
        [StringLength(1000, ErrorMessage = "Limit 200 characters")]
        public string Text4 { get; set; }
        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 7, Label = "Link 4 URL")]
        [EditingComponentProperty(nameof(TextAreaProperties.Name), "")]
        [StringLength(1000, ErrorMessage = "Limit 1000 characters")]
        public string Url4 { get; set; }

        [EditingComponent(TextAreaComponent.IDENTIFIER, Order = 8, Label = "Link 5 text")]
        [EditingComponentProperty(nameof(TextAreaProperties.Name), "")]
        [StringLength(1000, ErrorMessage = "Limit 200 characters")]
        public string Text5 { get; set; }
        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 9, Label = "Link 5 URL")]
        [EditingComponentProperty(nameof(TextAreaProperties.Name), "")]
        [StringLength(1000, ErrorMessage = "Limit 1000 characters")]
        public string Url5 { get; set; }

        [EditingComponent(TextAreaComponent.IDENTIFIER, Order = 10, Label = "Link 6 text")]
        [EditingComponentProperty(nameof(TextAreaProperties.Name), "")]
        [StringLength(1000, ErrorMessage = "Limit 200 characters")]
        public string Text6 { get; set; }
        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 11, Label = "Link 6 URL")]
        [EditingComponentProperty(nameof(TextAreaProperties.Name), "")]
        [StringLength(1000, ErrorMessage = "Limit 1000 characters")]
        public string Url6 { get; set; }

        [EditingComponent(TextAreaComponent.IDENTIFIER, Order = 12, Label = "Link 7 text")]
        [EditingComponentProperty(nameof(TextAreaProperties.Name), "")]
        [StringLength(1000, ErrorMessage = "Limit 200 characters")]
        public string Text7 { get; set; }
        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 13, Label = "Link 7 URL")]
        [EditingComponentProperty(nameof(TextAreaProperties.Name), "")]
        [StringLength(1000, ErrorMessage = "Limit 1000 characters")]
        public string Url7 { get; set; }

        [EditingComponent(TextAreaComponent.IDENTIFIER, Order = 14, Label = "Link 8 text")]
        [EditingComponentProperty(nameof(TextAreaProperties.Name), "")]
        [StringLength(1000, ErrorMessage = "Limit 200 characters")]
        public string Text8 { get; set; }
        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 15, Label = "Link 8 URL")]
        [EditingComponentProperty(nameof(TextAreaProperties.Name), "")]
        [StringLength(1000, ErrorMessage = "Limit 1000 characters")]
        public string Url8 { get; set; }

        [EditingComponent(TextAreaComponent.IDENTIFIER, Order = 16, Label = "Link 9 text")]
        [EditingComponentProperty(nameof(TextAreaProperties.Name), "")]
        [StringLength(1000, ErrorMessage = "Limit 200 characters")]
        public string Text9 { get; set; }
        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 17, Label = "Link 9 URL")]
        [EditingComponentProperty(nameof(TextAreaProperties.Name), "")]
        [StringLength(1000, ErrorMessage = "Limit 1000 characters")]
        public string Url9 { get; set; }

       
        [EditingComponent(TextAreaComponent.IDENTIFIER, Order = 18, Label = "Link 10 text")]
        [EditingComponentProperty(nameof(TextAreaProperties.Name), "")]
        [StringLength(1000, ErrorMessage = "Limit 200 characters")]
        public string Text10 { get; set; }
        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 19, Label = "Link 10 URL")]
        [EditingComponentProperty(nameof(TextAreaProperties.Name), "")]
        [StringLength(1000, ErrorMessage = "Limit 1000 characters")]
        public string Url10 { get; set; }


        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 20, Label = "Id")]
        [RegularExpression(@"^\S*$", ErrorMessage = "No white space allowed")]
        public string Id { get; set; }

        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 21, Label = "Class")]
        public string Class { get; set; }
    }
}