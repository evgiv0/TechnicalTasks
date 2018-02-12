using AreaCalculator;
using AreaCalculator.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AreaCalculatorTests
{
    [TestClass]
    public class AreaTests
    {
        [TestMethod]
        public void GetArea_PutNegativeValue_ShouldThrowArgumentException()
        {
            try
            {
                Area.GetArea(new Triangle(3, -1, 5, new RightTriangleType()));
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
                Area.GetArea(new Triangle(3, -1, 5, new RightTriangleType()));

            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("The triangle is not right", ex.Message);
            }
        }

        [TestMethod]
        public void GetArea_PutRightTriangle_ShouldReturnRightArea()
        {
            Assert.AreEqual(6, Area.GetArea(new Triangle(3, -1, 5, new RightTriangleType())));

            Assert.AreEqual(10, Area.GetArea(new Triangle(3, -1, 5, 0.1, new RightTriangleType())));
            Assert.AreEqual(3850, Area.GetArea(new Triangle(100, 77, 126.21, 0.1, new RightTriangleType())));
            Assert.AreEqual(60.43, Area.GetArea(new Triangle(15.3, 7.9, 17.21, 0.5, new RightTriangleType())));
        }
    }
}
