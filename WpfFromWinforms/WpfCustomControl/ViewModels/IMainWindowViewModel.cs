using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfCustomControl.ViewModels
{
    public interface IMainWindowViewModel : IDisposable
    {
        string DateInfo { get; set; }
    }
}
