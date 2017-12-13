namespace AreaCalculator.Abstract
{
    public abstract class Triangle : Shape
    {
        protected double SideA { get; set; }
        protected double SideB { get; set; }
        protected double SideC { get; set; }
        protected double Height { get; set; }
        protected double AllowedDifference { get; set; }


        protected Triangle()
        {
        }

        protected Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        protected Triangle(double sideA, double sideB, double sideC, double allowedDifference)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            AllowedDifference = allowedDifference;
        }
        //Другие конструкторы, для треугольников с другой формулой расчета площади...


        protected double GetPerimeter()
        {
            return SideA + SideB + SideC;
        }
    }
}
