namespace Lncodes.Tutorial.Singelton
{
    public sealed class ThreadSafeLazySingelton
    {
        private static ThreadSafeLazySingelton _instance = null;

        private static readonly object _instanceLock = new object();

        private ThreadSafeLazySingelton() { }

        public static ThreadSafeLazySingelton GetInstance()
        {
            if (_instance is null)
                lock (_instanceLock)
                    if (_instance is null)
                        _instance = new ThreadSafeLazySingelton();
            return _instance;
        }
    }
}
