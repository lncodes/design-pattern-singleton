using Xunit;
using Lncodes.Tutorial.Singelton;

namespace Lncodes.Singelton.Test
{
    public sealed class EagerSingeltonTest
    {
        [Fact]
        public void Check_EagerInstance_AreEqual()
        {
            var firstInstance = EagerSingelton.GetInstance();
            var secondInstance = EagerSingelton.GetInstance();
            Assert.Equal(firstInstance, secondInstance);
        }

        [Fact]
        public void Check_GenericEagerInstance_AreEqual()
        {
            var firstInstance = GenericEagerSingelton<EagerSingeltonTest>.GetInstance();
            var secondInstance = GenericEagerSingelton<EagerSingeltonTest>.GetInstance();
            Assert.Equal(firstInstance, secondInstance);
        }
    }
}
