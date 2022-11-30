#if VCONTAINER_SUPPORT

using VContainer;

namespace Dre0Dru.ScriptableServiceLocator.VContainer
{
    public static class VContainerExtensions
    {
        public static void RegisterInjectableScriptableService<TService>(this IContainerBuilder builder,
            ScriptableService<TService> scriptableService)
        {
            builder.RegisterBuildCallback(resolver =>
            {
                var injectableResolver = new InjectableResolver<TService>();
                resolver.Inject(injectableResolver);
                scriptableService.SetResolver(injectableResolver);
            });
        }
        
        public static void RegisterResolvableScriptableService<TService>(this IContainerBuilder builder,
            ScriptableService<TService> scriptableService)
        {
            builder.RegisterBuildCallback(resolver =>
            {
                scriptableService.SetResolver(new VContainerResolver<TService>(resolver));
            });
        }
        
    }
}

#endif
