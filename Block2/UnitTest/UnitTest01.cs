using System;
using Block2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest01
    {
        [TestMethod]
        public void GetMaxBothPositive()
        {
            // arrange
            int firstNumber = 20;
            int secondNumber = 15;

            //Act
            int max = Program.GetMax(firstNumber, secondNumber);

            //Assert
            Assert.AreEqual(20, max, "Here I am");
        }

        [TestMethod]
        public void GetMaxBothNegative()
        {
            int a = -12;
            int b = -3;
            int max = Program.GetMax(a, b);
            Assert.AreEqual(-3, max);
        }

        [TestMethod]
        public void GetMinBothPositive()
        {
            int a = 2;
            int b = 9;
            int min = Program.GetMin(a, b);
            Assert.AreEqual(2, min);
        }

        [TestMethod]
        public void GetMinBothNegative()
        {
            int a = -3;
            int b = -10;
            int min = Program.GetMin(a, b);
            Assert.AreEqual(-10, min);
        }
    }
}
