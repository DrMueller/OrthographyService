using Mmu.Mlh.NetFrameworkExtensions.Areas.Hooking.KeyboardHooking.Domain.Services;
using Mmu.Mlh.ServiceProvisioning.Areas.Initialization.Models;
using Mmu.Mlh.ServiceProvisioning.Areas.Initialization.Services;
using Mmu.Mlh.ServiceProvisioning.Areas.Provisioning.Services;

namespace Mmu.OrthographyService.Areas.Initialization
{
    public static class BootstrapService
    {
        public static void Start()
        {
            ContainerInitializationService.CreateInitializedContainer(new ContainerConfiguration(typeof(BootstrapService).Assembly, "Mmu.OrthographyService", true));
            var keyboardHookService = ServiceLocatorSingleton.Instance.GetService<IKeyboardHookService>();
            keyboardHookService.HookKeyboard();
        }
    }
}