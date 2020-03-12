using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SumOfArrayNumbersTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double[] inputArray = new double[] { 0, 3.14, 9.99999, 17.6, 4067.1, 2 };
            Assert.AreEqual(4099.8399899999995, SumOfArrayNumbers.Program.SumOfArrayNumbers(inputArray));
        }

        [TestMethod]
        public void TestMethod2()
        {
            double[] inputArray = new double[] { 0, 3.14, 9.99999, 17.6, 4067.1, 2 };
            Assert.AreNotEqual(2, SumOfArrayNumbers.Program.SumOfArrayNumbers(inputArray));
        }

        [TestMethod]
        public void TestMethod3()
        {
            double[] inputArray = new double[] { };
            Assert.AreEqual(0, SumOfArrayNumbers.Program.SumOfArrayNumbers(inputArray));
        }
    }
}
