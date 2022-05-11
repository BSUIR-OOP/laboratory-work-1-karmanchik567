using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Triangle : Figure
    {
        private const string _name = "Triangle";


        public Point A { get; set; }
        public Point B { get; set; }   
        public Point C { get; set; }


        public Triangle(double x, double y, double x1, double y1, double x2, double y2) : base(_name)
        {
            A = new Point(x, y);
            B = new Point(x1, y1);
            C = new Point(x2, y2);
        }


        public override string ToString() =>
            $"{Name} : {A}, {B}, {C}";   
    }
}
