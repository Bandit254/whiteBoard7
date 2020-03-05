using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CLockAngleTest
{
    [TestClass]
    public class ClockAngleUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(270, ClockAngle.CLockAngleProgram.ClockAngle(12, 15));
        }

    }
}
