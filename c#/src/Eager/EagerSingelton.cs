namespace Lncodes.Tutorial.Singelton
{
    public sealed class EagerSingelton
    {
        private static readonly EagerSingelton _instance = new EagerSingelton();

        private EagerSingelton() { }

        public static EagerSingelton GetInstance() =>
            _instance;
    }
}
