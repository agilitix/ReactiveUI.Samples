using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace WpfCustomControl.Models
{
    public class TimerModel
    {
        public IObservable<DateTime> CurrentDateTime { get; }

        public TimerModel()
        {
            CurrentDateTime = Observable.Interval(TimeSpan.FromSeconds(1)) // Should be produced in a background thread.
                                        .Select(_ => DateTime.Now);
        }
    }
}
