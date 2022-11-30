#if VCONTAINER_SUPPORT

using VContainer;

namespace Dre0Dru.ServiceLocator
{
    public static class VContainerExtensions
    {
        public static void SetService<TService>(this IContainerBuilder builder)
            where TService : class
        {
            builder.RegisterBuildCallback(resolver =>
            {
                Service<TService>.Set(resolver.Resolve<TService>());
            });
        }
    }
}

#endif
