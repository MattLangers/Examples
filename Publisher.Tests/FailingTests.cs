using NUnit.Framework;

namespace Publisher.Tests
{
    public class FailingTests
    {
        [Test]
        public void FailTestAndCheckCI()
        {
            Assert.IsTrue(false);
        }
    }
}
