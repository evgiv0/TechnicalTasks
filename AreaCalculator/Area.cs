﻿using AreaCalculator.Abstract;

namespace AreaCalculator
{
    public static class Area
    {
        public static double GetArea(Shape shape)
        {
            return shape.GetArea();
        }
    }
}
/*
 * В данной реализации для каждого типа фигуры предусмотрен свой класс, реализующий уникальный расчет площади.
 * Так же возможно выделение еще одного уровня абстракции для фигур, в данном случае для треугольников(прямоугольный, равнобедренный и т.д.), 
 * т.к. способы подсчета площади для одного вида могут отличаться.
 * К плюсам такой реализации можно отнести легкую расширяемость для новых видов и типов фигур.
 * К минусам: большое количество классов, 
 
*/