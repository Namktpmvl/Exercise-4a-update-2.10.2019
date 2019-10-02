using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise4_continue;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Power()
        {
            int result = Program.Power(2, 3);
            Assert.AreEqual(8,result);
        }

        [TestMethod]
        public void Square()
        {
            int result2 = Program.Square(2);
            Assert.AreEqual(4, result2);
        }

        [TestMethod]
        public void Cube()
        {
            int result3 = Program.Cube(3);
            Assert.AreEqual(27, result3);
        }

        [TestMethod]
        public void IsPrime()
        {
            bool result4 = Program.IsPrime(7);
            Assert.AreEqual(true, result4);
        }

        [TestMethod]
        public void Absolute()
        {
            int result5 = Program.Absolute(-149);
            Assert.AreEqual(149, result5);
        }
    }
}
