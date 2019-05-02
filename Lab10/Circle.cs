using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Circle
    {
        //vars
        private double radius;
        
        //constructors
        public Circle(double radius)
        {
            this.radius = radius;
        }
        //methods
        public double GetCircumference()
        {
            double circ = Math.Round((2 * Math.PI) * radius,2);
            return circ;
        }
        public double GetArea()
        {


            double area = Math.Round(Math.PI * Math.Pow(radius, 2),2);
            return area;
        }
        public void PrintInfo()
        {
            Console.WriteLine("i.  The Radius is " + radius);
            Console.WriteLine("ii.  The Area is " + GetArea());
            Console.WriteLine("iii.  The Circumference is " + GetCircumference());
            Console.WriteLine();
        }
    }
}
