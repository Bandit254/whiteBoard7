using Microsoft.VisualStudio.TestTools.UnitTesting;
using CountLetters;

namespace CountLettersTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(23, CountLetters.Program.CountLetters("We're in MSSA CAD #7 in San Diego"));
        }
    }
}
