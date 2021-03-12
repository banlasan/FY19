using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FY19.Models.Widgets
{
    public class KMJ_LinkButtonProperties : IWidgetProperties
    {
        [EditingComponent(TextAreaComponent.IDENTIFIER, Order = 0, Label = "Text Content")]
        [EditingComponentProperty(nameof(TextAreaProperties.Name), "")]
        [StringLength(200, ErrorMessage = "Limit 200 characters")]
        [Required]
        public string TextContent { get; set; }

        [EditingComponent(TextAreaComponent.IDENTIFIER, Order = 0, Label = "Url")]
        [EditingComponentProperty(nameof(TextAreaProperties.Name), "")]
        [StringLength(200, ErrorMessage = "Limit 1000 characters")]
        [Required]
        public string Url { get; set; }

        [EditingComponent(TextAreaComponent.IDENTIFIER, Order = 0, Label = "IsOpenNewWindow")]
        [EditingComponentProperty(nameof(TextAreaProperties.Name), "")]
        [Required]
        public bool IsOpenNewWindow { get; set; }

        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 1, Label = "Id")]
        [StringLength(200, ErrorMessage = "Limit 200 characters")]
        public string Id { get; set; }

        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 2, Label = "Class")]
        [StringLength(200, ErrorMessage = "Limit 200 characters")]
        public string Class { get; set; }
    }
}