using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FY19.Models.Sections
{
    public class KMJ_ColumnZoneProperties : ISectionProperties
    {
        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 0, Label = "Id")]
        [StringLength(200, ErrorMessage = "Limit 200 characters")]
        public string Id { get; set; }

        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 1, Label = "Class")]
        [StringLength(200, ErrorMessage = "Limit 200 characters")]
        public string Class { get; set; }

        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 2, Label = "Color")]
        public string Color { get; set; } = "#4a2626";
    }
}