using System;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Dre0Dru.VContainer
{
    public abstract class ScriptableInstaller : ScriptableObject, IInstaller, IDisposable
    {
        public abstract void Install(IContainerBuilder builder);

        public virtual void Dispose()
        {
        }
    }
}
