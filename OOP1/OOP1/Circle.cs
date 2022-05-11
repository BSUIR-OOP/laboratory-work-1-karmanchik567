namespace OOP1
{
    public class Circle : Centralized
    {
        private const string _name = "Circle";


        public double Radius { get; }


        public Circle(double x, double y, double radius) : base(_name, x, y)
        {
            Radius = radius;
        }


        public override string ToString() => 
            $"{Name} : centre = {Centre}, radius = {Radius}";
    }
}
