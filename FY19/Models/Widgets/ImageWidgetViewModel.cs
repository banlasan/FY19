using CMS.MediaLibrary;

namespace FY19.Models.Widgets
{
    /// <summary>
    /// View model for image widget.
    /// </summary>
    public class ImageWidgetViewModel
    {
        /// <summary>
        /// Background image.
        /// </summary>
        public MediaFileInfo Image { get; set; }


        /// <summary>
        /// Text.
        /// </summary>
        public string Text { get; set; }


        /// <summary>
        /// Button text.
        /// </summary>
        public string ButtonText { get; set; }


        /// <summary>
        /// Target of button link.
        /// </summary>
        public string ButtonTarget { get; set; }
    }
}