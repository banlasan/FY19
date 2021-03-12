using System;
using CMS.SiteProvider;
using CMS.MediaLibrary;

namespace FY19.Models.InlineEditors
{
    public class EditableTextViewModel : InlineEditorViewModel
    {
        public string Text { get; set; }

        //public string MediaUrl { get; set; } = MediaLibraryHelper.GetDirectUrl(MediaLibraryInfoProvider.GetMediaLibraryInfo("FY19", SiteContext.CurrentSiteName)); 

        public Guid Id { get; set; } = Guid.NewGuid();
    }
}