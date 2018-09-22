using System;

namespace WpfCustomControl
{
    public interface IBootstrapper : IDisposable
    {
        void Startup();
    }
}
