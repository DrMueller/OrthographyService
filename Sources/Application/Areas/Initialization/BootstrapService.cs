using System.Reflection;
using Mmu.Mlh.ApplicationExtensions.Areas.DependencyInjection.Models;
using Mmu.Mlh.ApplicationExtensions.Areas.DependencyInjection.Services;
using Mmu.Mlh.ApplicationExtensions.Areas.ServiceProvisioning;
using Mmu.Mlh.NetFrameworkExtensions.Areas.Hooking.KeyboardHooking.Domain.Services;

namespace Mmu.OrthographyService.Areas.Initialization
{
    public static class BootstrapService
    {
        public static void Start()
        {
            ContainerInitializationService.CreateInitializedContainer(new AssemblyParameters(typeof(BootstrapService).Assembly, "Mmu.OrthographyService"));
            var keyboardHookService = ProvisioningServiceSingleton.Instance.GetService<IKeyboardHookService>();
            keyboardHookService.HookKeyboard();
        }
    }
}