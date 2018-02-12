using AreaCalculator.Concrete;

namespace AreaCalculator.Abstract
{
    public class Triangle : Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public double Height { get; set; }
        public double AllowedDifference { get; set; }
        public TriangleType TriangleType { get; set; }


        protected Triangle()
        {
        }

        protected Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            TriangleType = new RightTriangleType();
        }

        protected Triangle(double sideA, double sideB, double sideC, TriangleType triangleType) : this(sideA, sideB, sideC)
        {
            TriangleType = triangleType;
        }


        protected Triangle(double sideA, double sideB, double sideC, double allowedDifference) : this(sideA, sideB, sideC)
        {
            AllowedDifference = allowedDifference;
        }

        protected Triangle(double sideA, double sideB, double sideC, double allowedDifference, TriangleType triangleType) : this(sideA, sideB, sideC, allowedDifference)
        {
            TriangleType = triangleType;
        }


        public override double GetArea()
        {

        }



    }
}
