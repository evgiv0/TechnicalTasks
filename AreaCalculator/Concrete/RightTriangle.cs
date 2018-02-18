using AreaCalculator.Abstract;
using System;

namespace AreaCalculator.Concrete
{
    public class RightTriangle : Triangle
    {
        public RightTriangle(double sideA, double sideB, double sideC) : base(sideA, sideB, sideC)
        {
        }

        public RightTriangle(double sideA, double sideB, double sideC, double allowedDifference) : base(sideA, sideB, sideC, allowedDifference)
        {
        }

        /// <summary>
        /// Check for triangle is right. Exception will throw otherwise
        /// </summary>
        /// <exception cref="ArgumentException">Will throw when one of the triangle`s sides less/equal 0 or when the received triangle is not right.</exception>
        protected override void IsRightFigure()
        {
            if (!CheckForPositiveValues())
                throw new ArgumentException("All sides of the triangle must be greater then 0");

            if (!IsRightTriangle())
                throw new ArgumentException("The triangle is not right");
        }

        protected override double GetAreaFigure()
        {
            var halfPerimeter = GetPerimeter() / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - SideA)
                                   * (halfPerimeter - SideB)
                                   * (halfPerimeter - SideC)); ;
        }

        private bool CheckForPositiveValues()
        {
            return (SideA > 0 && SideB > 0 && SideC > 0);
        }

        private bool IsRightTriangle()
        {
            return ((Math.Abs(SideA * SideA + SideB * SideB - SideC * SideC) <= AllowedDifference)
                   || (Math.Abs(SideA * SideA + SideC * SideC - SideB * SideB) <= AllowedDifference)
                   || (Math.Abs(SideB * SideB + SideC * SideC - SideA * SideA) <= AllowedDifference));
        }
    }
}

