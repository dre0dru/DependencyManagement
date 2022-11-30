namespace Dre0Dru.ScriptableServiceLocator
{
    public static class ScriptableServicesExtensions
    {
        public static void FromInstance<TService>(this ScriptableService<TService> scriptableService, TService service)
        {
            scriptableService.SetResolver(new InstanceResolver<TService>(service));
        }
    }
}
