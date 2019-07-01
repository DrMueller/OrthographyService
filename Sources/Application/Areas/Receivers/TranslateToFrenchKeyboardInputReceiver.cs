﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mmu.Mlazh.LanguageService.Translations.Areas.Services;
using Mmu.Mlh.LanguageExtensions.Areas.Types.Options;
using Mmu.Mlh.NetFrameworkExtensions.Areas.Hooking.KeyboardHooking.Domain.Models.Configurations;
using Mmu.Mlh.NetFrameworkExtensions.Areas.Hooking.KeyboardHooking.Domain.Models.Inputs;
using Mmu.OrthographyService.Areas.Clipboards.Services;

namespace Mmu.OrthographyService.Areas.Receivers
{
    public class TranslateToFrenchKeyboardInputReceiver : TranslateKeyboardInputReceiverBase
    {
        private readonly Lazy<KeyboardEventConfiguration> _lazyConfiguration = new Lazy<KeyboardEventConfiguration>(
            () => new KeyboardEventConfiguration(
                new KeyboardInputKeyConfiguration(KeyboardInputKey.F),
                new ModifierConfiguration(
                    true,
                    Option.CreateNotApplicable<bool>(true),
                    Option.CreateNotApplicable<bool>(true)),
                LockConfiguration.CreateNotApplicable()));
        public override KeyboardEventConfiguration Configuration => _lazyConfiguration.Value;
        protected override string TargetLanguageCode { get; } = "fr";

        public TranslateToFrenchKeyboardInputReceiver(ITranslationService translationService, IClipboardProxy clipboardService) : base(translationService, clipboardService)
        {
        }
    }
}
