namespace Lncodes.Tutorial.Singelton
{
    public abstract class GenericEagerSingelton<T> where T : class, new()
    {
        private readonly static T _instance = new T();

        protected GenericEagerSingelton(){ }

        public static T GetInstance() => 
            _instance;
    }
}
