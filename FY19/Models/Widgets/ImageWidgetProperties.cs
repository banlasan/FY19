using System;
using Kentico.PageBuilder.Web.Mvc;

namespace FY19.Models.Widgets
{
    /// <summary>
    /// Properties of Image widget.
    /// </summary>
    public class ImageWidgetProperties : IWidgetProperties
    {
        /// <summary>
        /// Guid of an image to be displayed.
        /// </summary>
        public Guid ImageGuid { get; set; }
    }
}