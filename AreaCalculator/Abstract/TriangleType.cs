using System;

namespace AreaCalculator.Abstract
{
    public abstract class TriangleType : FigureType
    {
        public override bool IsRightFigure(Shape shape)
        {
            if (!(shape is Triangle))
                throw new ArgumentException("Figure is not a triangle.");

            var currentTrinagle = (Triangle)shape;

            if (!(currentTrinagle.SideA > 0 && currentTrinagle.SideB > 0 && currentTrinagle.SideC > 0))
                return false;
            return true;
        }

        protected double GetPerimeter(Triangle shape)
        {
            var currentTrinagle = (Triangle)shape;
            return currentTrinagle.SideA + currentTrinagle.SideB + currentTrinagle.SideC;
        }
    }
}
