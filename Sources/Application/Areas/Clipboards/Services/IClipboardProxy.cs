namespace Mmu.OrthographyService.Areas.Clipboards.Services
{
    public interface IClipboardProxy
    {
        void SetText(string text);

        string GetText();
    }
}