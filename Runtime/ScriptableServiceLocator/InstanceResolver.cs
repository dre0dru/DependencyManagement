namespace Dre0Dru.ScriptableServiceLocator
{
    public class InstanceResolver<TService> : IServiceResolver<TService>
    {
        private TService _service;

        public InstanceResolver(TService service)
        {
            _service = service;
        }

        public TService Resolve()
        {
            return _service;
        }

        public void Dispose()
        {
            _service = default(TService);
        }
    }
}
