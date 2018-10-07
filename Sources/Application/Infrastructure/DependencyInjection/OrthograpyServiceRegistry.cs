using Mmu.Mlh.NetFrameworkExtensions.Areas.Hooking.KeyboardHooking.Domain.Services;
using StructureMap;

namespace Mmu.OrthographyService.Infrastructure.DependencyInjection
{
    public class OrthograpyServiceRegistry : Registry
    {
        public OrthograpyServiceRegistry()
        {
            Scan(
                scanner =>
                {
                    scanner.AssembliesAndExecutablesFromApplicationBaseDirectory();
                    scanner.AddAllTypesOf<IKeyboardInputReceiver>();
                    scanner.WithDefaultConventions();
                });
        }
    }
}