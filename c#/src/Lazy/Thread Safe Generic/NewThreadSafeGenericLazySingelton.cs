using System;

namespace Lncodes.Tutorial.Singelton
{
    public abstract class NewThreadSafeGenericLazySingelton<T> where T : class, new()
    {
        private static readonly Lazy<T> instance = new Lazy<T>(CreateInstance);

        protected NewThreadSafeGenericLazySingelton() { }

        private static T CreateInstance() =>
            new T();

        public static T GetInstance() =>
            instance.Value;
    }
}
