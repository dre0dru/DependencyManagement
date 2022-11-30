using Dre0Dru.ServiceLocator;

namespace Dre0Dru.ScriptableServiceLocator.ServiceLocator
{
    public class ServiceLocatorResolver<TService> : IServiceResolver<TService>
        where TService : class
    {
        public TService Resolve()
        {
            return Service<TService>.Value;
        }

        public void Dispose()
        {
            Service<TService>.Clear();
        }
    }
}
