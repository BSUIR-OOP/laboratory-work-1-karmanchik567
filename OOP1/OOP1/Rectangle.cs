namespace OOP1
{
    public class Rectangle : Centralized
    {
        private const string _name = "Rectangle";


        public double Height { get; set; }

        public double Width { get; set; }


        public Rectangle(double x, double y, double h, double w) : base(_name, x, y)
        {
            Width = w;
            Height = h;
        }


        public override string ToString() =>
            $"{Name} : centre = {Centre}; width = {Width}, height = {Height}";
    }
}
