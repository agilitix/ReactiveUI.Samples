using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Concurrency;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms.Integration;
using CommonServiceLocator;
using MahApps.Metro.Controls;
using ReactiveUI;
using Unity;
using Unity.Injection;
using Unity.Lifetime;
using Unity.ServiceLocation;
using WpfCustomControl.Models;
using WpfCustomControl.ViewModels;
using WpfCustomControl.Views;

namespace WpfCustomControl
{
    public class Bootstrapping : IBootstrapping
    {
        protected readonly IUnityContainer _unity;

        public Bootstrapping(IScheduler uiScheduler)
        {
            _unity = new UnityContainer();

            _unity.RegisterInstance(uiScheduler);

            _unity.RegisterSingleton<ITimerModel, TimerModel>();
            _unity.RegisterSingleton<IMainWindowViewModel, MainWindowViewModel>();
            _unity.RegisterSingleton<IViewFor<IMainWindowViewModel>, MainWindow>();
        }

        public void Startup()
        {
            Window mainWindow = _unity.Resolve<IViewFor<IMainWindowViewModel>>() as Window;
            ElementHost.EnableModelessKeyboardInterop(mainWindow);
            mainWindow.ShowDialog();
        }

        public void Dispose()
        {
            _unity?.Dispose();
        }
    }
}
