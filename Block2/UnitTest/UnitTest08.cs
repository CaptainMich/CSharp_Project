using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise8;

namespace UnitTest
{
    [TestClass]
    public class UnitTest08
    {
        [TestMethod]
        public void GcdPrimeNumbers()
        {
            int gcd = Program.GreatestCommonDivisor(17, 13);
            Assert.AreEqual(1, gcd);
        }

        [TestMethod]
        public void GcdEqualsNumbers()
        {
            int gcd = Program.GreatestCommonDivisor(18, 18);
            Assert.AreEqual(18, gcd);
        }

        [TestMethod]
        public void GcdRandomNumbers()
        {
            int gcd = Program.GreatestCommonDivisor(56, 42);
            Assert.AreEqual(14, gcd);
        }

        [TestMethod]
        public void LcmRandomNumbers()
        {
            int gcd = Program.LeastCommonMultiple(34, 63);
            Assert.AreEqual(2142, gcd);
        }

        [TestMethod]
        public void LcmEqualsNumbers()
        {
            int gcd = Program.LeastCommonMultiple(8, 8);
            Assert.AreEqual(8, gcd);
        }

        [TestMethod]
        public void LcmPrimeNumbers()
        {
            int gcd = Program.LeastCommonMultiple(7, 11);
            Assert.AreEqual(77, gcd);
        }
    }
}
