using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;
using System.ComponentModel.DataAnnotations;
namespace FY19.Models.Widgets
{
    public class KMJ_LinkListProperties : IWidgetProperties
    {
        [EditingComponent(TextAreaComponent.IDENTIFIER, Order = 0, Label = "Link 1 text")]
        [EditingComponentProperty(nameof(TextAreaProperties.Name), "")]
        [StringLength(1000, ErrorMessage = "Limit 1000 characters")]
        public string Text1 { get; set; }
        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 1, Label = "Link 1 URL")]
        [StringLength(1000, ErrorMessage = "Limit 1000 characters")]
        public string Url1 { get; set; }
        [EditingComponent(CheckBoxComponent.IDENTIFIER, Order = 2, Label = "Opens Link 1 in a new window")]
        [EditingComponentProperty(nameof(CheckBoxProperties.Name), "false")]
        public bool Blank1 { get; set; }
        [EditingComponent(TextAreaComponent.IDENTIFIER, Order = 3, Label = "Link 1 description")]
        [EditingComponentProperty(nameof(TextAreaProperties.Name), "")]
        [StringLength(1000, ErrorMessage = "Limit 1000 characters")]
        public string Description1 { get; set; }



        [EditingComponent(TextAreaComponent.IDENTIFIER, Order = 4, Label = "Link 2 text")]
        [EditingComponentProperty(nameof(TextAreaProperties.Name), "")]
        [StringLength(1000, ErrorMessage = "Limit 1000 characters")]
        public string Text2 { get; set; }
        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 5, Label = "Link 2 URL")]
        [StringLength(1000, ErrorMessage = "Limit 1000 characters")]
        public string Url2 { get; set; }
        [EditingComponent(CheckBoxComponent.IDENTIFIER, Order = 6, Label = "Opens Link 2 in a new window")]
        [EditingComponentProperty(nameof(CheckBoxProperties.Name), "false")]
        public bool Blank2 { get; set; }
        [EditingComponent(TextAreaComponent.IDENTIFIER, Order = 7, Label = "Link 2 description")]
        [EditingComponentProperty(nameof(TextAreaProperties.Name), "")]
        [StringLength(1000, ErrorMessage = "Limit 1000 characters")]
        public string Description2 { get; set; }



        [EditingComponent(TextAreaComponent.IDENTIFIER, Order = 8, Label = "Link 3 text")]
        [EditingComponentProperty(nameof(TextAreaProperties.Name), "")]
        [StringLength(1000, ErrorMessage = "Limit 1000 characters")]
        public string Text3 { get; set; }
        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 9, Label = "Link 3 URL")]
        [StringLength(1000, ErrorMessage = "Limit 1000 characters")]
        public string Url3 { get; set; }
        [EditingComponent(CheckBoxComponent.IDENTIFIER, Order = 10, Label = "Opens Link 3 in a new window")]
        [EditingComponentProperty(nameof(CheckBoxProperties.Name), "false")]
        public bool Blank3 { get; set; }
        [EditingComponent(TextAreaComponent.IDENTIFIER, Order = 11, Label = "Link 3 description")]
        [EditingComponentProperty(nameof(TextAreaProperties.Name), "")]
        [StringLength(1000, ErrorMessage = "Limit 1000 characters")]
        public string Description3 { get; set; }



        [EditingComponent(TextAreaComponent.IDENTIFIER, Order = 12, Label = "Link 4 text")]
        [EditingComponentProperty(nameof(TextAreaProperties.Name), "")]
        [StringLength(1000, ErrorMessage = "Limit 1000 characters")]
        public string Text4 { get; set; }
        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 13, Label = "Link 4 URL")]
        [StringLength(1000, ErrorMessage = "Limit 1000 characters")]
        public string Url4 { get; set; }
        [EditingComponent(CheckBoxComponent.IDENTIFIER, Order = 14, Label = "Opens Link 4 in a new window")]
        [EditingComponentProperty(nameof(CheckBoxProperties.Name), "false")]
        public bool Blank4 { get; set; }
        [EditingComponent(TextAreaComponent.IDENTIFIER, Order = 15, Label = "Link 4 description")]
        [EditingComponentProperty(nameof(TextAreaProperties.Name), "")]
        [StringLength(1000, ErrorMessage = "Limit 1000 characters")]
        public string Description4 { get; set; }


        [EditingComponent(TextAreaComponent.IDENTIFIER, Order = 16, Label = "Link 5 text")]
        [EditingComponentProperty(nameof(TextAreaProperties.Name), "")]
        [StringLength(1000, ErrorMessage = "Limit 1000 characters")]
        public string Text5 { get; set; }
        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 17, Label = "Link 5 URL")]
        [StringLength(1000, ErrorMessage = "Limit 1000 characters")]
        public string Url5 { get; set; }
        [EditingComponent(CheckBoxComponent.IDENTIFIER, Order = 18, Label = "Opens Link 5 in a new window")]
        [EditingComponentProperty(nameof(CheckBoxProperties.Name), "false")]
        public bool Blank5 { get; set; }
        [EditingComponent(TextAreaComponent.IDENTIFIER, Order = 19, Label = "Link 5 description")]
        [EditingComponentProperty(nameof(TextAreaProperties.Name), "")]
        [StringLength(1000, ErrorMessage = "Limit 1000 characters")]
        public string Description5 { get; set; }



        [EditingComponent(TextAreaComponent.IDENTIFIER, Order = 20, Label = "Link 6 text")]
        [EditingComponentProperty(nameof(TextAreaProperties.Name), "")]
        [StringLength(1000, ErrorMessage = "Limit 1000 characters")]
        public string Text6 { get; set; }
        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 21, Label = "Link 6 URL")]
        [StringLength(1000, ErrorMessage = "Limit 1000 characters")]
        public string Url6 { get; set; }
        [EditingComponent(CheckBoxComponent.IDENTIFIER, Order = 22, Label = "Opens Link 6 in a new window")]
        [EditingComponentProperty(nameof(CheckBoxProperties.Name), "false")]
        public bool Blank6 { get; set; }
        [EditingComponent(TextAreaComponent.IDENTIFIER, Order = 23, Label = "Link 6 description")]
        [EditingComponentProperty(nameof(TextAreaProperties.Name), "")]
        [StringLength(1000, ErrorMessage = "Limit 1000 characters")]
        public string Description6 { get; set; }



        [EditingComponent(TextAreaComponent.IDENTIFIER, Order = 24, Label = "Link 7 text")]
        [EditingComponentProperty(nameof(TextAreaProperties.Name), "")]
        [StringLength(1000, ErrorMessage = "Limit 1000 characters")]
        public string Text7 { get; set; }
        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 25, Label = "Link 7 URL")]
        [StringLength(1000, ErrorMessage = "Limit 1000 characters")]
        public string Url7 { get; set; }
        [EditingComponent(CheckBoxComponent.IDENTIFIER, Order = 26, Label = "Opens Link 7 in a new window")]
        [EditingComponentProperty(nameof(CheckBoxProperties.Name), "false")]
        public bool Blank7 { get; set; }
        [EditingComponent(TextAreaComponent.IDENTIFIER, Order = 27, Label = "Link 7 description")]
        [EditingComponentProperty(nameof(TextAreaProperties.Name), "")]
        [StringLength(1000, ErrorMessage = "Limit 1000 characters")]
        public string Description7 { get; set; }



        [EditingComponent(TextAreaComponent.IDENTIFIER, Order = 28, Label = "Link 8 text")]
        [EditingComponentProperty(nameof(TextAreaProperties.Name), "")]
        [StringLength(1000, ErrorMessage = "Limit 1000 characters")]
        public string Text8 { get; set; }
        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 29, Label = "Link 8 URL")]
        [StringLength(1000, ErrorMessage = "Limit 1000 characters")]
        public string Url8 { get; set; }
        [EditingComponent(CheckBoxComponent.IDENTIFIER, Order = 30, Label = "Opens Link 8 in a new window")]
        [EditingComponentProperty(nameof(CheckBoxProperties.Name), "false")]
        public bool Blank8 { get; set; }
        [EditingComponent(TextAreaComponent.IDENTIFIER, Order = 31, Label = "Link 8 description")]
        [EditingComponentProperty(nameof(TextAreaProperties.Name), "")]
        [StringLength(1000, ErrorMessage = "Limit 1000 characters")]
        public string Description8 { get; set; }


        [EditingComponent(TextAreaComponent.IDENTIFIER, Order = 32, Label = "Link 9 text")]
        [EditingComponentProperty(nameof(TextAreaProperties.Name), "")]
        [StringLength(1000, ErrorMessage = "Limit 1000 characters")]
        public string Text9 { get; set; }
        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 33, Label = "Link 9 URL")]
        [StringLength(1000, ErrorMessage = "Limit 1000 characters")]
        public string Url9 { get; set; }
        [EditingComponent(CheckBoxComponent.IDENTIFIER, Order = 34, Label = "Opens Link 9 in a new window")]
        [EditingComponentProperty(nameof(CheckBoxProperties.Name), "false")]
        public bool Blank9 { get; set; }
        [EditingComponent(TextAreaComponent.IDENTIFIER, Order = 35, Label = "Link 9 description")]
        [EditingComponentProperty(nameof(TextAreaProperties.Name), "")]
        [StringLength(1000, ErrorMessage = "Limit 1000 characters")]
        public string Description9 { get; set; }



        [EditingComponent(TextAreaComponent.IDENTIFIER, Order = 36, Label = "Link 10 text")]
        [EditingComponentProperty(nameof(TextAreaProperties.Name), "")]
        [StringLength(1000, ErrorMessage = "Limit 1000 characters")]
        public string Text10 { get; set; }
        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 37, Label = "Link 10 URL")]
        [StringLength(1000, ErrorMessage = "Limit 1000 characters")]
        public string Url10 { get; set; }
        [EditingComponent(CheckBoxComponent.IDENTIFIER, Order = 38, Label = "Opens Link 10 in a new window")]
        [EditingComponentProperty(nameof(CheckBoxProperties.Name), "false")]
        public bool Blank10 { get; set; }
        [EditingComponent(TextAreaComponent.IDENTIFIER, Order = 39, Label = "Link 10 description")]
        [EditingComponentProperty(nameof(TextAreaProperties.Name), "")]
        [StringLength(1000, ErrorMessage = "Limit 1000 characters")]
        public string Description10 { get; set; }

        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 40, Label = "Id")]
        public string Id { get; set; }

        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 41, Label = "Class")]
        public string Class { get; set; }
    }
}