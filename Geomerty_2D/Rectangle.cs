using System;
namespace Geometry2D
{
	public class Rectangle : Figure
	{
        private Point P2;
        private double K;
        public Rectangle(Point px, Point p2, double k) : base(px)
		{
			P2 = p2; K = k;
		}
        public override double getSquare()
        {
            return Math.Pow(Base - P2, 2) * K / (1 + K * K);
        }
        public override string ToString()
        {
            return $"Прямоугольник\nБазовая точка: {Base}\n" +
                $"Противолежащая вершина: {P2:f4}\n" +
                $"Площадь: {getSquare():f4}\n";
        }
    }
}

