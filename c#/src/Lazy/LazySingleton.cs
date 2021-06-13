namespace Lncodes.Tutorial.Singelton
{
    public sealed class LazySingleton
    {
        private static LazySingleton _instance = null;

        private LazySingleton() { }

        public static LazySingleton GetInstance()
        {
            if (_instance is null)
                _instance = new LazySingleton();
            return _instance;
        }
    }
}
