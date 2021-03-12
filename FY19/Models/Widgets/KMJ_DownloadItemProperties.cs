using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using Kentico.Components.Web.Mvc.FormComponents;
using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;

namespace FY19.Models.Widgets
{
    public class KMJ_DownloadItemProperties : IWidgetProperties
    {
        /// <summary>
        /// Media library name.
        /// </summary>
        public const string MEDIA_LIBRARY_NAME = "FY19";


        /// <summary>
        /// Guid of background image.
        /// </summary>
        [EditingComponent(MediaFilesSelector.IDENTIFIER, Label = "Image", Order = 1)]
        [EditingComponentProperty(nameof(MediaFilesSelectorProperties.LibraryName), MEDIA_LIBRARY_NAME)]
        [EditingComponentProperty(nameof(MediaFilesSelectorProperties.MaxFilesLimit), 1)]
        [EditingComponentProperty(nameof(MediaFilesSelectorProperties.AllowedExtensions), ".gif;.png;.jpg;.jpeg")]
        [Required]
        public IList<MediaFilesSelectorItem> Image { get; set; }


        /// <summary>
        /// Text to be displayed.
        /// </summary>
        public string Text { get; set; }


        /// <summary>
        /// Button text.
        /// </summary>
        public string ButtonText { get; set; }


        /// <summary>
        /// Target of button link.
        /// </summary>
        [EditingComponent(TextInputComponent.IDENTIFIER, Label = "Button Target", Order = 2)]
        public string ButtonTarget { get; set; }
    }
}