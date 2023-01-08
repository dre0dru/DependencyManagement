using System;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Dre0Dru.VContainer
{
    public class LifetimeScopeBase : LifetimeScope
    {
        [SerializeField]
        private MonoInstaller[] _monoInstallers;

        [SerializeField]
        private ScriptableInstaller[] _scriptableInstallers;

        protected sealed override void Configure(IContainerBuilder builder)
        {
            try
            {
                foreach (var scope in _monoInstallers)
                {
                    scope.Install(builder);
                }

                foreach (var scope in _scriptableInstallers)
                {
                    scope.Install(builder);
                }
                
                OnConfigure(builder);
            }
            catch (Exception e)
            {
                Debug.LogException(e);
                throw;
            }
        }

        protected virtual void OnConfigure(IContainerBuilder builder)
        {
            
        }

        protected sealed override void OnDestroy()
        {
            base.OnDestroy();

            try
            {
                foreach (var scope in _monoInstallers)
                {
                    scope.Dispose();
                }

                foreach (var scope in _scriptableInstallers)
                {
                    scope.Dispose();
                }
                
                OnDispose();
            }
            catch (Exception e)
            {
                Debug.LogException(e);
                throw;
            }
        }

        protected virtual void OnDispose()
        {
            
        }
    }
}
