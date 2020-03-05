using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringMirrorImageTest
{
    [TestClass]
    public class StringMirrorImageUnitTest
    {
        //For calling the method you are testing, the syntax is: "Namespace.Classname.Methodname"

        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("olleH", StringMirrorImage.StringMirrorImageProgram.MirrorImageString("Hello"));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreNotEqual("Hello", StringMirrorImage.StringMirrorImageProgram.MirrorImageString("Hello"));
        }
    }
}
