namespace OOP1
{
    public class Rhombus : Centralized
    {
        private const string _name = "Rhombus";

        public double Width { get; set; }
        public double Height { get; set; }


        public Rhombus(double w, double h, double x, double y) : base(_name, x, y)
        {
            Width = w;
            Height = h;
        }

        public override string ToString() => $"{Name}: centre = {Centre}, width = {Width}, height = {Height}";
    }
}
