namespace Dre0Dru.ScriptableServiceLocator.ServiceLocator
{
    public static class ServiceLocatorExtensions
    {
        public static void RegisterServiceLocatorScriptableService<TService>(this ScriptableService<TService> scriptableService)
            where TService : class
        {
            scriptableService.SetResolver(new ServiceLocatorResolver<TService>());
        }
    }
}
