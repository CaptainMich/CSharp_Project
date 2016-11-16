using System;
using System.Numerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise2;

namespace UnitTest
{
    [TestClass]
    public class UnitTest02
    {
        [TestMethod]
        public void Fibonacci20()
        {
            BigInteger result = Program.Fibonacci(20)[19];
            Assert.AreEqual(4181, result, "Error: number shouldn't be " + result);
        }


        [TestMethod]
        public void Fibonacci40()
        {
            BigInteger result = Program.Fibonacci(40)[39];
            Assert.AreEqual(63245986, result, "Error: number shouldn't be " + result);
        }


        [TestMethod]
        public void Fibonacci60()
        {
            BigInteger result = Program.Fibonacci(60)[59];
            Assert.AreEqual(956722026041, result, "Error: number shouldn't be " + result);
        }

        [TestMethod]
        public void Fibonacci80()
        {
            BigInteger result = Program.Fibonacci(80)[79];
            Assert.AreEqual(14472334024676221, result, "Error: number shouldn't be " + result);
        }

        [TestMethod]
        public void Fibonacci100()
        {
            BigInteger result = Program.Fibonacci(100)[99];
            BigInteger exp = BigInteger.Parse("218922995834555169026");
            Assert.AreEqual(exp, result, "Error: number shouldn't be " + result);
        }
    }
}
