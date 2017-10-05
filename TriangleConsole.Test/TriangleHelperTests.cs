using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TriangleConsole.Test
{
    [TestClass]
    public class TriangleHelperTests
    {
        [TestMethod]
        public void ThreeEqualValuesShouldReturnEquilateral()
        {
            Assert.AreEqual(TriangleHelper.GetTriangleType(1.5, 1.5, 1.5), TriangleType.Equilateral);
        }

        [TestMethod]
        public void InvaliInputShouldReturnNotATriangle()
        {
            Assert.AreEqual(TriangleHelper.GetTriangleType(4, 6, 0), TriangleType.NotATriangle);
        }

        [TestMethod]
        public void TwoEqualValuesShouldReturnIsoceles()
        {
            Assert.AreEqual(TriangleHelper.GetTriangleType(3, 4, 4), TriangleType.Isosceles);
        }

        [TestMethod]
        public void NoEqualValuesShouldReturnScelene()
        {
            Assert.AreEqual(TriangleHelper.GetTriangleType(4.4, 7.3, 9.1), TriangleType.Scalene);
        }
    }
}
