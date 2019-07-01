﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mmu.Mlazh.LanguageService.Translations.Areas.Models;
using Mmu.Mlazh.LanguageService.Translations.Areas.Services;
using Mmu.Mlh.NetFrameworkExtensions.Areas.Hooking.KeyboardHooking.Domain.Models.Configurations;
using Mmu.Mlh.NetFrameworkExtensions.Areas.Hooking.KeyboardHooking.Domain.Models.Inputs;
using Mmu.Mlh.NetFrameworkExtensions.Areas.Hooking.KeyboardHooking.Domain.Services;
using Mmu.OrthographyService.Areas.Clipboards.Services;
using Mmu.OrthographyService.Infrastructure.Context;

namespace Mmu.OrthographyService.Areas.Receivers
{
    public abstract class TranslateKeyboardInputReceiverBase : IKeyboardInputReceiver
    {
        private readonly IClipboardProxy _clipboardService;
        private readonly ITranslationService _translationService;

        protected TranslateKeyboardInputReceiverBase(
            ITranslationService translationService,
            IClipboardProxy clipboardService)
        {
            _translationService = translationService;
            _clipboardService = clipboardService;
        }

        public abstract KeyboardEventConfiguration Configuration { get; }
        protected abstract string TargetLanguageCode { get; }

        public async Task ReceiveAsync(KeyboardInput input)
        {
            await ErrorHandler.HandledActionAsync(async () =>
            {
                var currentText = _clipboardService.GetText();
                if (string.IsNullOrEmpty(currentText) || currentText.Length > 1000)
                {
                    return;
                }

                var translation = await TranslateAsync(currentText);
                _clipboardService.SetText(translation);
            });
        }

        private async Task<string> TranslateAsync(string sourceText)
        {
            var translationResults = await _translationService.AutoTranslateAsync(
                new AutoDetectLanguageTranslationRequest(
                    new List<string> { TargetLanguageCode },
                    new List<string> { sourceText }));

            var mostaccurateTranslationResult = translationResults.OrderBy(f => f.DetectedLanguage.AccuracyBetweenOneAndZero).First();
            return mostaccurateTranslationResult.Translations.First().Text;
        }
    }
}