using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise3;
namespace UnitTest
{
    [TestClass]
    public class UnitTest03
    {
        [TestMethod]
        public void TestPositiveDiscriminant()
        {
            double delta = Program.GetDiscriminant(4, 9, 2);
            Assert.AreEqual(49, delta, "Error: result shouldn't be " + delta);
        }

        [TestMethod]
        public void TestZeroDiscriminant()
        {
            double delta = Program.GetDiscriminant(1, 2, 1);
            Assert.AreEqual(0, delta, "Error: discriminant should be " + 0);
        }

        [TestMethod]
        public void TestNegativeDiscriminant()
        {
            double delta = Program.GetDiscriminant(1, 1, 1);
            Assert.AreEqual(-3, delta, "Error: discriminant should be " + -3);
        }

        [TestMethod]
        public void SolveQuadrEqTestDifferentRoots()
        {
            double[] expected = { 3d, 2d };
            double[] roots = Program.SolveQuadraticEq(1, -5, 6);
            CollectionAssert.AreEqual(expected, roots);
        }

        [TestMethod]
        public void SolveQuadrEqTestSingleRoot()
        {
            double[] expected = { -1d };
            double[] roots = Program.SolveQuadraticEq(1, 2, 1);
            CollectionAssert.AreEqual(expected, roots);
        }

        [TestMethod]
        public void SolveQuadrEqTestNotRealRoots()
        {
            double[] roots = Program.SolveQuadraticEq(1, 1, 1);
            Assert.AreEqual(0, roots.Length);
        }
    }
}
