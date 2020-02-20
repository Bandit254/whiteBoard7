using Microsoft.VisualStudio.TestTools.UnitTesting;
using PyramidBrickCount;

namespace PyramidBrickCountUnitTest
{
    [TestClass]
    public class BrickCountTest
    {
        [TestMethod]
        public void BrickCountTest_8824()
        {
            Assert.AreEqual(8824, countBricks.CountOfBricks(100, 30, .17));
        }
        [TestMethod]
        public void BrickCountTest_8000()
        {
            Assert.AreNotEqual(8000, countBricks.CountOfBricks(100, 30, .17));
        }
    }
}
