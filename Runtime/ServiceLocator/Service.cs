namespace Dre0Dru.ServiceLocator
{
    //TODO extensions that return IDisposable registration to clear service
    public class Service<T>
        where T : class
    {
        private static T _instance;

        public static T Value => _instance;

        public static void Set(T value)
        {
            _instance = value;
        }

        public static void Clear()
        {
            _instance = default(T);
        }
    }
}