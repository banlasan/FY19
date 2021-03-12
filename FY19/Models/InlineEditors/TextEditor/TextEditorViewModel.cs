
namespace FY19.Models.InlineEditors
{
    public class TextEditorViewModel : InlineEditorViewModel
    {
        public string Id { get; set; }
        public string Class { get; set; }
        public string Text { get; set; }
        public bool IsOpenNewWindow { get; set; } = false;
        public bool EnableFormatting { get; set; } = true;
    }
}