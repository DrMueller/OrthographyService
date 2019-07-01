using System;
using Mmu.Mlazh.LanguageService.Translations.Areas.Services;
using Mmu.Mlh.LanguageExtensions.Areas.Types.Options;
using Mmu.Mlh.NetFrameworkExtensions.Areas.Hooking.KeyboardHooking.Domain.Models.Configurations;
using Mmu.Mlh.NetFrameworkExtensions.Areas.Hooking.KeyboardHooking.Domain.Models.Inputs;
using Mmu.OrthographyService.Areas.Clipboards.Services;

namespace Mmu.OrthographyService.Areas.Receivers
{
    public class TranslateToGermanKeyboardInputReceiver : TranslateKeyboardInputReceiverBase
    {
        private readonly Lazy<KeyboardEventConfiguration> _lazyConfiguration = new Lazy<KeyboardEventConfiguration>(
            () => new KeyboardEventConfiguration(
                new KeyboardInputKeyConfiguration(KeyboardInputKey.G),
                new ModifierConfiguration(
                    true,
                    Option.CreateNotApplicable<bool>(true),
                    Option.CreateNotApplicable<bool>(true)),
                LockConfiguration.CreateNotApplicable()));
        public override KeyboardEventConfiguration Configuration => _lazyConfiguration.Value;
        protected override string TargetLanguageCode { get; } = "de";

        public TranslateToGermanKeyboardInputReceiver(ITranslationService translationService, IClipboardProxy clipboardService) : base(translationService, clipboardService)
        {
        }
    }
}