using Mmu.Mlazh.LanguageService.Translations.Infrastructure.Settings.Models;
using Mmu.Mlazh.LanguageService.Translations.Infrastructure.Settings.Services;

namespace Mmu.OrthographyService.Infrastructure.Translations
{
    public class TranslationServiceSettingsProvider : ITranslationServiceSettingsProvider
    {
        public TranslationServiceSettings ProvideSettings()
        {
            return new TranslationServiceSettings("045dc19faafb43afa35dc34e033ef1fe");
        }
    }
}