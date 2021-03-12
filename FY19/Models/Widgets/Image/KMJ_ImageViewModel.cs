using CMS.MediaLibrary;

namespace FY19.Models.Widgets
{
    public class KMJ_ImageViewModel
    {
        public MediaFileInfo Image { get; set; }

        public MediaFileInfo ImageSP { get; set; }

        public string Alt { get; set; }

        public string Id { get; set; }

        public string Image_class { get; set; }
    }
}