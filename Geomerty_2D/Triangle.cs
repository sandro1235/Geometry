using System;
namespace Geometry2D
{
	public class Triangle : Figure
    {
        private Point P1, P2;
        public Triangle(Point px, Point p1, Point p2) : base(px)
        {
            P1 = p1; P2 = p2;
        }
        public override double getSquare()
        {
            return Math.Abs((Base.X - P2.X) * (P1.Y - P2.Y) -
                (P1.X - P2.X) * (Base.Y - P2.Y)) / 2.0;
        }
        public override string ToString()
        {
            return $"Треугольник\n" +
                $"Базовая точка: {Base} \n" +
                $"Вершины: {P1} {P2}\n" +
                $"Площадь: {getSquare():f4}\n";
        }
    }
}

