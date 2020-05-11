using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(OOP_lab_1_16_1.Program.Perymetr(3, 4), 12);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(OOP_lab_1_16_1.Program.Pifagor(3, 4), 5);
        }
    }
}
