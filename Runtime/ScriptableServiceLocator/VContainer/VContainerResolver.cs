#if VCONTAINER_SUPPORT

using VContainer;

namespace Dre0Dru.ScriptableServiceLocator.VContainer
{
    public class VContainerResolver<TService> : IServiceResolver<TService>
    {
        private IObjectResolver _resolver;

        public VContainerResolver(IObjectResolver resolver)
        {
            _resolver = resolver;
        }

        public TService Resolve() =>
            _resolver.Resolve<TService>();

        public void Dispose() =>
            _resolver = null;
    }
}

#endif
