using System;
namespace Geometry2D
{
	public class Circle : Figure
	{
        private double R;
        public Circle(Point px, double r) : base(px) 
		{
			R = r;
		}
        public override double getSquare()
        {
            return (double)(Math.PI * R * R);
        }
        public override string ToString()
        {
            return $"Окружность\nЦентр: {Base} \n" +
                $"Радиус: {R:f4}\nПлощадь: {getSquare():f4}\n";
        }
    }
}

