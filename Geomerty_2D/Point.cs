using System;
//using System.Numerics;

namespace Geometry2D
{
	public class Point
	{
        public double X { get; } = 0.0;
        public double Y { get; } = 0.0;
        public Point()
		{
        }
        public Point(double x, double y)
        {
            X = x; Y = y;
        }
		// Расстояние между точками
        public static double operator- (Point t1, Point t2)
        {
            double dx = t1.X - t2.X, dy = t1.Y - t2.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
        public override string ToString()
        {
            return $"({X:f4}, {Y:f4})";
        }
    }
}

