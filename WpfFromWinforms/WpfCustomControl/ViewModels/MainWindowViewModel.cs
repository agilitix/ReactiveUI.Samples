using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Concurrency;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;

namespace WpfCustomControl.ViewModels
{
    public class MainWindowViewModel : ReactiveObject, IDisposable
    {
        private IScheduler _scheduler;

        public MainWindowViewModel(IScheduler scheduler)
        {
            _scheduler = scheduler;
        }

        public void Dispose()
        {
        }
    }
}
