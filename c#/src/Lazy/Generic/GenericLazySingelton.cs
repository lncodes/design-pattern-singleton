namespace Lncodes.Tutorial.Singelton
{
    public abstract class GenericLazySingelton<T> where T : class, new()
    {
        private static T _instance = null;

        protected GenericLazySingelton() { }

        public static T GetInstance()
        {
            if (_instance is null)
                _instance = new T();
            return _instance;
        }
    }
}
