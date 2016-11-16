using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise5;

namespace UnitTest
{
    [TestClass]
    public class UnitTest05
    {
        [TestMethod]
        public void TestN0andX1()
        {
            double n = 0;
            double x = 1;
            double result = Program.GetSum(n, x);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestN2andX5()
        {
            double n = 2;
            double x = 5;
            double result = Program.GetSum(n, x);
            Assert.AreEqual(1.28d, result);
        }
    }
}
