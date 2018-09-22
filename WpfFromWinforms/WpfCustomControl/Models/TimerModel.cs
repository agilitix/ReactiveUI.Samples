using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace WpfCustomControl.Models
{
    public class TimerModel : ITimerModel
    {
        public IObservable<DateTime> CurrentDateTime { get; }

        public TimerModel()
        {
            CurrentDateTime = Observable.Interval(TimeSpan.FromSeconds(1), NewThreadScheduler.Default)
                                        .Select(_ => DateTime.Now);
        }

        public void Dispose()
        {
        }
    }
}
