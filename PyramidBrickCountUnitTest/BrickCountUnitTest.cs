namespace PyramidBrickCountUnitTest
{
    [TestClass]
    public class BrickCountUnitTest
    {
        [TestMethod]
        public void BrickCountTest_8824()
        {
            Assert.AreEqual(8824, PyramidBrickCount.PyramidBrickCount.CountOfBricks(100, 30, .17));
        }
        [TestMethod]
        public void BrickCountTest_8000()
        {
            Assert.AreNotEqual(8000, PyramidBrickCount.PyramidBrickCount.CountOfBricks(100, 30, .17));
        }
    }
}
