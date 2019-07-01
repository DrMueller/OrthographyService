using Mmu.Mlazh.LanguageService.Translations.Infrastructure.Settings.Models;
using Mmu.Mlazh.LanguageService.Translations.Infrastructure.Settings.Services;

namespace Mmu.OrthographyService.Infrastructure.Translations
{
    public class TranslationServiceSettingsProvider : ITranslationServiceSettingsProvider
    {
        public TranslationServiceSettings ProvideSettings()
        {
            return new TranslationServiceSettings("6b1a3edf9b514968950cb3fd040ef9eb");
        }
    }
}