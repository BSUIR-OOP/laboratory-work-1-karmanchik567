namespace OOP1
{
    public struct Point
    {
        public double X = default;
        public double Y = default;


        public Point(double x, double y)
        {
            Y = y;
            X = x;
        }


        public override string ToString() => $"({X}, {Y})";
    }


    public abstract class Centralized : Figure
    {
        protected Point Centre { get; } = new Point();


        public Centralized(string name, double x, double y) : base(name)
        {
            Centre = new Point(x, y);
        }
    }
}
