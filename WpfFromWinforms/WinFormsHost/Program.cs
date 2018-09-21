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

namespace WinFormsHost
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            IScheduler mainScheduler = new DispatcherScheduler(Dispatcher.CurrentDispatcher);
            MainWindow mainWindow = new MainWindow(mainScheduler);
            ElementHost.EnableModelessKeyboardInterop(mainWindow); // "C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\v3.0\WindowsFormsIntegration.dll"
            mainWindow.ShowDialog();
        }
    }
}
