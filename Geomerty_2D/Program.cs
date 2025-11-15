using System;
using System.Collections.Generic;
using Geometry2D;

namespace Geomerty_2D
{
    public class Program
    {
        static void Main(string[] args)
        {
            Point A = new Point();
            Circle C = new Circle(A, 10.0);
            Triangle T = new Triangle(A, new Point(4.0, 4.0), new Point(4.0, -4.0));
            Rectangle R = new Rectangle(A, new Point(4.0, 4.0), 0.5);
            var F = new List<Figure> { C, T, R };
            foreach (var f in F)
            {
                Console.WriteLine(f);
            }
        }
    }
}
