using Xunit;
using Lncodes.Tutorial.Singelton;

namespace Lncodes.Singelton.Test
{
    public sealed class LazySingeltonTest
    {
        [Fact]
        public void Check_LazyInstance_AreEqual()
        {
            var firstInstance = LazySingleton.GetInstance();
            var secondInstance = LazySingleton.GetInstance();
            Assert.Equal(firstInstance, secondInstance);
        }

        [Fact]
        public void Check_GenericLazyInstance_AreEqual()
        {
            var firstInstance = GenericLazySingelton<LazySingeltonTest>.GetInstance();
            var secondInstance = GenericLazySingelton<LazySingeltonTest>.GetInstance();
            Assert.Equal(firstInstance, secondInstance);
        }

        [Fact]
        public void Check_ThreadSafeLazyInstance_AreEqual()
        {
            ThreadSafeLazySingelton firstInstance = ThreadSafeLazySingelton.GetInstance();
            ThreadSafeLazySingelton secondInstance = ThreadSafeLazySingelton.GetInstance();
            Assert.Equal(firstInstance, secondInstance);
        }

        [Fact]
        public void Check_NewThreadSafeLazyInstance_AreEqual()
        {
            var firstInstance = NewThreadSafeLazySingelton.GetInstance();
            var secondInstance = NewThreadSafeLazySingelton.GetInstance();
            Assert.Equal(firstInstance, secondInstance);
        }

        [Fact]
        public void Check_ThreadSafeGenericLazyInstance_AreEqual()
        {
            var firstInstance = ThreadSafeGenericLazySingelton<LazySingeltonTest>.GetInstance();
            var secondInstance = ThreadSafeGenericLazySingelton<LazySingeltonTest>.GetInstance();
            Assert.Equal(firstInstance, secondInstance);
        }

        [Fact]
        public void Check_NewThreadSafeGenericLazyInstance_AreEqual()
        {
            var firstInstance = NewThreadSafeGenericLazySingelton<LazySingeltonTest>.GetInstance();
            var secondInstance = NewThreadSafeGenericLazySingelton<LazySingeltonTest>.GetInstance();
            Assert.Equal(firstInstance, secondInstance);
        }
    }
}
