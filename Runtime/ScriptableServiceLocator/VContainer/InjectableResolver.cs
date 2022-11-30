#if VCONTAINER_SUPPORT

using VContainer;

namespace Dre0Dru.ScriptableServiceLocator.VContainer
{
    public class InjectableResolver<TService> : IServiceResolver<TService>
    {
        [Inject]
        public TService Service { get; protected set; }
        
        public TService Resolve() =>
            Service;

        public void Dispose() =>
            Service = default(TService);
    }
}

#endif
