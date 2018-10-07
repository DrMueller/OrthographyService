using System;
using System.Windows.Forms;
using Mmu.OrthographyService.Areas.Initialization;

namespace Mmu.OrthographyService.TaskRunner
{
    internal class Program
    {
        [STAThread]
        private static void Main()
        {
            BootstrapService.Start();
            Application.Run();
        }
    }
}