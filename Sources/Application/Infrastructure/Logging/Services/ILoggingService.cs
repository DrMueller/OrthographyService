using System;

namespace Mmu.OrthographyService.Infrastructure.Logging.Services
{
    public interface ILoggingService
    {
        void LogException(Exception ex);

        void LogInfo(string message);
    }
}