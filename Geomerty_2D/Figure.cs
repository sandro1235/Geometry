namespace Geometry2D
{
    public abstract class Figure
	{
        public Point Base { get; }
        public Figure(Point px) { Base = px; }
        public abstract double getSquare(); // площадь фигуры
    }
}

