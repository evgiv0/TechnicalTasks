namespace AreaCalculator.Abstract
{
    public abstract class FigureType
    {
        public abstract bool IsRightFigure(Shape shape);
        public abstract double GetArea(Shape shape);
    }
}
