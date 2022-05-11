using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Line : Figure
    {
        private const string _name = "Line";


        public Point A { get; set; }
        public Point B { get; set; }


        public Line(double x1, double y1, double x2, double y2) : base(_name)
        {
            A = new Point(x1, y1);
            B = new Point(x2, y2);
        }


        public override string ToString() =>
            $"{Name} : {A}, {B}";
    }
}
