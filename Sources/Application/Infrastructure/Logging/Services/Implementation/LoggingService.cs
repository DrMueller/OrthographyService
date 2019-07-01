using System;
using Mmu.Mlh.LanguageExtensions.Areas.Invariance;
using NLog;

namespace Mmu.OrthographyService.Infrastructure.Logging.Services.Implementation
{
    public class LoggingService : ILoggingService
    {
        private static readonly ILogger Logger = LogManager.GetLogger(nameof(LoggingService));

        public void LogException(Exception ex)
        {
            Guard.ObjectNotNull(() => ex);
            Logger.Error(ex, ex.Message);
        }

        public void LogInfo(string message)
        {
            Guard.StringNotNullOrEmpty(() => message);
            Logger.Info(message);
        }
    }
}