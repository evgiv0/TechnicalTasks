using System;

namespace AreaCalculator.Abstract
{
    public abstract class Shape
    {
        public FigureType FigureType { get; set; }

        
        public virtual double GetArea(FigureType figureType)
        {

            if (!figureType.IsRightFigure(this))
            {
                throw new ArgumentException("figure is not right");
            }
            return figureType.GetArea(this);

        }
    }
}
