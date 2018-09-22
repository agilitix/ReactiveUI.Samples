using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfCustomControl.Models
{
    public interface ITimerModel : IDisposable
    {
        IObservable<DateTime> CurrentDateTime { get; }
    }
}
