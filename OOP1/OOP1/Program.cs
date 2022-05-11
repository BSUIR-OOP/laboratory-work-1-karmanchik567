namespace OOP1
{
    static class Program
    {
        public static void Main()
        {
            var circle = new Circle(5, 10, 20);
            Console.WriteLine(circle);

            var rectangle = new Rectangle(10, 20, 30, 40);
            Console.WriteLine(rectangle);

            var triangle = new Triangle(10, 20, 10, 30, 10, 40);
            Console.WriteLine(triangle);

            var line = new Line(0, 0, 10, 10);
            Console.WriteLine(line);

            var ellipse = new Ellipse(10, 20, 10, 10);
            Console.WriteLine(ellipse);

            var rhombus = new Rhombus(10, 20, 10, 10);
            Console.WriteLine(rhombus);
        }
    }
}
