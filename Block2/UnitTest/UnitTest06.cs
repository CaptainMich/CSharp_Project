using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise6;

namespace UnitTest
{
    [TestClass]
    public class UnitTest06
    {
        // Test for cheking input by user
        [TestMethod]
        public void IsDecimalPositiveInteger()
        {
            //Arrange
            string number = "20";

            //Act
            bool checkDecimal = Program.isDecimal(number);

            //Assert
            Assert.AreEqual(true, checkDecimal);
        }

        [TestMethod]
        public void IsDecimalHexNumber()
        {
            //Arrange
            string number = "205f";

            //Act
            bool checkDecimal = Program.isDecimal(number);

            //Assert
            Assert.AreEqual(false, checkDecimal);
        }

        [TestMethod]
        public void IsBinaryBinaryNumber()
        {
            //Arrange
            string number = "01010111";

            //Act
            bool checkBinary = Program.isBinary(number);

            //Assert
            Assert.AreEqual(true, checkBinary);
        }

        [TestMethod]
        public void IsBinaryPositiveNumber()
        {
            //Arrange
            string number = "23455654";

            //Act
            bool checkBinary = Program.isBinary(number);

            //Assert
            Assert.AreEqual(false, checkBinary);
        }

        [TestMethod]
        public void IsHexadecimalHexNumber()
        {
            //Arrange
            string number = "345ff";

            //Act
            bool checkHexadecimal = Program.isHexadecimal(number);

            //Assert
            Assert.AreEqual(true, checkHexadecimal);
        }

        // Test for cheking input conversion
        [TestMethod]
        public void DecimalToBinaryPositiveInteger()
        {
            //Arrange
            int number = 5;

            //Act
            string binaryConversion = Program.DecimalToBinary(number);

            //Assert
            Assert.AreEqual("101", binaryConversion);
        }

        [TestMethod]
        public void BinaryToDecimalFiveBit()
        {
            //Arrange
            string number = "01011";

            //Act
            int decimalConversion = Program.BinaryToDecimal(number);

            //Assert
            Assert.AreEqual(11, decimalConversion);
        }

        [TestMethod]
        public void DecimalToHexPositiveInteger()
        {
            //Arrange
            int number = 123;

            //Act
            string hexadecimalConversion = Program.DecimalToHex(number);

            //Assert
            Assert.AreEqual("7B", hexadecimalConversion);
        }

        [TestMethod]
        public void HexToDecimalSixDigits()
        {
            //Arrange
            string number = "78654f";

            //Act
            int decimalConversion = Program.HexToDecimal(number);

            //Assert
            Assert.AreEqual(7890255, decimalConversion);
        }
    }
}
