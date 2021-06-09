using System.Collections.Generic;
using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using Kentico.Components.Web.Mvc.FormComponents;

namespace FY19.Models.Widgets
{
    public class KMJ_ImageProperties : IWidgetProperties
    {
        public const string MEDIA_LIBRARY_NAME = "FY19";

        [EditingComponent(MediaFilesSelector.IDENTIFIER, Label = "Image", Order = 0)]
        [EditingComponentProperty(nameof(MediaFilesSelectorProperties.LibraryName), MEDIA_LIBRARY_NAME)]
        [EditingComponentProperty(nameof(MediaFilesSelectorProperties.MaxFilesLimit), 1)]
        [EditingComponentProperty(nameof(MediaFilesSelectorProperties.AllowedExtensions), ".gif;.png;.jpg;.jpeg")]
        [Required]
        public IList<MediaFilesSelectorItem> Image { get; set; }

        [EditingComponent(MediaFilesSelector.IDENTIFIER, Label = "Image (for SP)", Order = 1)]
        [EditingComponentProperty(nameof(MediaFilesSelectorProperties.LibraryName), MEDIA_LIBRARY_NAME)]
        [EditingComponentProperty(nameof(MediaFilesSelectorProperties.MaxFilesLimit), 1)]
        [EditingComponentProperty(nameof(MediaFilesSelectorProperties.AllowedExtensions), ".gif;.png;.jpg;.jpeg")]

        public IList<MediaFilesSelectorItem> ImageSP { get; set; }

        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 2, Label = "Alt")]
        [StringLength(200, ErrorMessage = "Limit 200 characters")]
        public string Alt { get; set; }

        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 3, Label = "Id")]
        [RegularExpression(@"^\S*$", ErrorMessage = "No white space allowed")]
        public string Id { get; set; }

        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 4, Label = "Class")]
        public string Image_class { get; set; }

    }
}