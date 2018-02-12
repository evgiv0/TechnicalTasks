using AreaCalculator.Abstract;
using System;

namespace AreaCalculator.Concrete
{
    public class RightTriangleType : TriangleType
    {
        public override bool IsRightFigure(Shape shape)
        {
            if (!IsRightTriangle((Triangle)shape))
                throw new ArgumentException("The triangle is not right");
            return base.IsRightFigure(shape);
        }

        public override double GetArea(Shape shape)
        {
            var currentTriangle = shape as Triangle;
            var halfPerimeter = GetPerimeter((Triangle)shape) / 2;
            var result = Math.Sqrt(halfPerimeter * (halfPerimeter - currentTriangle.SideA)
                                   * (halfPerimeter - currentTriangle.SideB)
                                   * (halfPerimeter - currentTriangle.SideC));
            return Math.Round(result, 2);
        }

        private bool IsRightTriangle(Triangle triangle)
        {
            return ((Math.Abs(triangle.SideA * triangle.SideA + triangle.SideB * triangle.SideB - triangle.SideC * triangle.SideC) <= triangle.AllowedDifference)
                   || (Math.Abs(triangle.SideA * triangle.SideA + triangle.SideC * triangle.SideC - triangle.SideB * triangle.SideB) <= triangle.AllowedDifference)
                   || (Math.Abs(triangle.SideB * triangle.SideB + triangle.SideC * triangle.SideC - triangle.SideA * triangle.SideA) <= triangle.AllowedDifference));
        }
    }
}
