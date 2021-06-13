using System;

namespace Lncodes.Tutorial.Singelton
{
    public sealed class NewThreadSafeLazySingelton
    {
        private static readonly Lazy<NewThreadSafeLazySingelton> _instance = new Lazy<NewThreadSafeLazySingelton>(CreateInstance);

        private NewThreadSafeLazySingelton() { }

        private static NewThreadSafeLazySingelton CreateInstance() =>
            new NewThreadSafeLazySingelton();

        public static NewThreadSafeLazySingelton GetInstance() =>
            _instance.Value;
    }
}
