using Microsoft.VisualStudio.TestTools.UnitTesting;
//MAKE NOTE OF THIS NAMESPACE JAZZ GOING ON
namespace DataStructuresTestingUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //initialize
            int x = 5;
            int expected = 5;

            //act

            //assert
            Assert.AreEqual(expected, x);
        }
    }
}
