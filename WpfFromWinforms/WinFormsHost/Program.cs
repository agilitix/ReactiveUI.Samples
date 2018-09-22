using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Concurrency;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using System.Windows.Threading;
using WpfCustomControl;
using MainWindow = WpfCustomControl.Views.MainWindow;

namespace WinFormsHost
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            // UI scheduler.
            IScheduler mainScheduler = new DispatcherScheduler(Dispatcher.CurrentDispatcher);

            IBootstrapper boot = new Bootstrapper(mainScheduler);
            boot.Startup();
            boot.Dispose();
        }
    }
}
