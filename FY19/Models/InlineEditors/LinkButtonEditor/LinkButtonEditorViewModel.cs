using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FY19.Models.InlineEditors.LinkButtonEditor
{
    public class LinkButtonEditorViewModel : InlineEditorViewModel
    {
        public string Id { get; set; }
        public string TextContent { get; set; }
        public string Url { get; set; }
        public bool IsOpenNewWindow { get; set; } = true;
        public bool EnableFormatting { get; set; } = true;
    }
}