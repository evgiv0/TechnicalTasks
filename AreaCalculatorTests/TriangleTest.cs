using AreaCalculator;
using AreaCalculator.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AreaCalculatorTests
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void GetArea_PutNegativeValue_ShouldThrowArgumentException()
        {
            try
            {
                Area.GetArea(new RightTriangle(3, -1, 5));
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("All sides of the triangle must be greater then 0", ex.Message);
            }
        }

        [TestMethod]
        public void GetArea_PutNotRightTriangle_ShouldThrowArgumentException()
        {
            try
            {
                Area.GetArea(new RightTriangle(3, 10, 1));
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("The triangle is not right", ex.Message);
            }
        }

        [TestMethod]
        public void GetArea_PutRightTriangle_ShouldReturnRightArea()
        {
            Assert.AreEqual(6, Area.GetArea(new RightTriangle(3, 4, 5)));
            Assert.AreEqual(10, Area.GetArea(new RightTriangle(4, 5, 6.4031, 0.1)));
            Assert.AreEqual(3850, Area.GetArea(new RightTriangle(100, 77, 126.21, 0.1)));
            Assert.AreEqual(60.43, Area.GetArea(new RightTriangle(15.3, 7.9, 17.21, 0.5)));
        }
    }
}
