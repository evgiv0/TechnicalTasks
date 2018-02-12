using System;

namespace AreaCalculator.Abstract
{
    public abstract class Shape
    {
        public virtual double GetArea(FigureType figureType)
        {
            try { 
            if (figureType.IsRightFigure(this)) {
                    return figureType.GetArea(this);
                }
            }
            catch
            {
                throw;
            }

        }
    }
}
