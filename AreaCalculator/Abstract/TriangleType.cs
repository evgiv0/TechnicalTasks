using AreaCalculator.Concrete;
using System;

namespace AreaCalculator.Abstract
{
    public abstract class TriangleType : FigureType
    {
        public override bool IsRightFigure(Shape shape)
        {
            var currentTrinagle = (Triangle)shape;

            if (!(currentTrinagle.SideA > 0 && currentTrinagle.SideB > 0 && currentTrinagle.SideC > 0))
                throw new ArgumentException("All sides of the triangle must be greater then 0");

            return true;
        }

        protected double GetPerimeter(Triangle shape)
        {
            var currentTrinagle = (Triangle)shape;
            return currentTrinagle.SideA + currentTrinagle.SideB + currentTrinagle.SideC;
        }
    }
}
