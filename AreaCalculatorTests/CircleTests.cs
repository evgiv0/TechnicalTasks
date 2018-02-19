using AreaCalculator;
using AreaCalculator.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AreaCalculatorTests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void GetArea_PutNagativeRadius_ShouldThrowArgumentException()
        {
            try
            {
                Area.GetArea(new Circle(-10));
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Radius must be greater then 0", ex.Message);
            }
        }

        [TestMethod]
        public void GetArea_PutCircle_ShouldReturnRightArea()
        {
            Assert.AreEqual(314.159, Area.GetArea(new Circle(10)));
            Assert.AreEqual(78.54, Area.GetArea(new Circle(5)));
            Assert.AreEqual(0.785, Area.GetArea(new Circle(0.5)));
        }
    }
}
