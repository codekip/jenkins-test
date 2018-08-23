using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLib;

namespace TESTUnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_One()
        {
            Class1 c = new Class1();
            Assert.AreEqual(1, c.Num());
        }
    }
}