namespace OOP1
{
    public class Ellipse : Centralized
    {
        private const string _name = "Ellipse";


        public double RadiusX { get; }
        public double RadiusY { get; }


        public Ellipse(double x, double y, double rx, double ry) : base(_name, x, y)
        {
            RadiusX = rx;
            RadiusY = ry;
        }

        public override string ToString() => $"{Name}: centre = {Centre}, radius x = {RadiusX}, radius y = {RadiusY}";
    }
}
