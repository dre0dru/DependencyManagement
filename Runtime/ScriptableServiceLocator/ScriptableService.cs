using System;
using UnityEngine;

namespace Dre0Dru.ScriptableServiceLocator
{
    //TODO can be made without allocs by constraining TResolver by interface
    public class ScriptableService<TService> : ScriptableObject, IDisposable
    {
        private IServiceResolver<TService> _serviceResolver;

        public TService Service => _serviceResolver.Resolve();

        public void Dispose()
        {
            _serviceResolver?.Dispose();
        }

        public void SetResolver(IServiceResolver<TService> resolver)
        {
            _serviceResolver?.Dispose();
            _serviceResolver = resolver;
        }

        public static implicit operator TService(ScriptableService<TService> scriptableService) =>
            scriptableService.Service;
    }
}
