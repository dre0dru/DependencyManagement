using System;

namespace Dre0Dru.ScriptableServiceLocator
{
    public interface IServiceResolver<out TService> : IDisposable
    {
        TService Resolve();
    }
}
