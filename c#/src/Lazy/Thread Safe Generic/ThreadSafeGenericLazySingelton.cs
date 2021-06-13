namespace Lncodes.Tutorial.Singelton
{
    public abstract class ThreadSafeGenericLazySingelton<T> where T : class, new()
    {
        private static T _instance = null;

        private static readonly object _instanceLock = new object();

        protected ThreadSafeGenericLazySingelton() { }

        public static T GetInstance()
        {
            if (_instance is null)
                lock (_instanceLock)
                    if (_instance is null)
                        _instance = new T();
            return _instance;
        }
    }
}
