using AreaCalculator.Abstract;
using System;

namespace AreaCalculator.Concrete
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }
        protected override double GetAreaFigure()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        protected override void IsRightFigure()
        {
            if (Radius <= 0)
                throw new ArgumentException("Radius must be greater then 0");
        }

        protected override double RoundValue(double receivedArea, int accuracy)
        {
            return base.RoundValue(receivedArea, 3);
        }
    }
}
