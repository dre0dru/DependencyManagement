using UnityEngine;
using UnityEngine.Pool;

namespace Dre0Dru.ComponentDependencies
{
    public static class ComponentDependenciesExtensions 
    {
        public static void SetDependency<TDependency>(this GameObject root, TDependency dependency)
        {
            using (ListPool<IDependant<TDependency>>.Get(out var list))
            {
                root.GetComponentsInChildren<IDependant<TDependency>>(true, list);

                foreach (var dependant in list)
                {
                    dependant.SetDependency(dependency);
                }
            }
        }

        public static void SetDependency<TDependency>(this Component root, TDependency dependency)
        {
            root.gameObject.SetDependency(dependency);
        }
    }
}
