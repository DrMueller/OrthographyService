using System.Windows.Forms;

namespace Mmu.OrthographyService.Areas.Clipboards.Services.Implementation
{
    public class ClipboardProxy : IClipboardProxy
    {
        public string GetText()
        {
            return Clipboard.GetText();
        }

        public void SetText(string text)
        {
            Clipboard.SetText(text);
        }
    }
}