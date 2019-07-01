using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mmu.Mlh.ApplicationExtensions.Areas.Logging.Services;
using Mmu.Mlh.ServiceProvisioning.Areas.Provisioning.Services;

namespace Mmu.OrthographyService.Infrastructure.Context
{
    public static class ErrorHandler
    {
        public static async Task HandledActionAsync(Func<Task> action)
        {
            try
            {
                await action();
            }
            catch (Exception ex)
            {
                var loggingService = ServiceLocatorSingleton.Instance.GetService<ILoggingService>();
                loggingService.LogException(ex);
            }
        }
    }
}