using System;

namespace WpfCustomControl
{
    public interface IBootstrapping : IDisposable
    {
        void Startup();
    }
}
