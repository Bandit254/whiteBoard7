using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CapitalLetterCountTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(4, CapitalLetterCount.Program.CapitalLetterCount("The San Diego Zoo"));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreNotEqual(4, CapitalLetterCount.Program.CapitalLetterCount("Zachary Silvis"));
        }
    }
}
