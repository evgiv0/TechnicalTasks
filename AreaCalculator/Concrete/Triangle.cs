using AreaCalculator.Abstract;

namespace AreaCalculator.Concrete
{
    public class Triangle : Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public double Height { get; set; }
        public double AllowedDifference { get; set; }



        protected Triangle()
        {
        }

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            FigureType = new RightTriangleType();
        }

        public Triangle(double sideA, double sideB, double sideC, TriangleType triangleType) : this(sideA, sideB, sideC)
        {
            FigureType = triangleType;
        }


        public Triangle(double sideA, double sideB, double sideC, double allowedDifference) : this(sideA, sideB, sideC)
        {
            AllowedDifference = allowedDifference;
        }

        public Triangle(double sideA, double sideB, double sideC, double allowedDifference, TriangleType triangleType) : this(sideA, sideB, sideC, allowedDifference)
        {
            FigureType = triangleType;
        }
    }
}
