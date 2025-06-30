using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal interface Ishape
    {
        double calculatearea();
    }
    class circle : Ishape
    {
        public double radius { get; set; }
        public circle(double Radius)
        {
            radius = Radius;
        }
        public double  calculatearea()
        {
           return Math.PI * radius * radius;

        }
    }
    class Rectangle: Ishape
    {
        public double length { get; set; }
        public double breadth { get; set; }
        public Rectangle(double Length, double Breadth)
        {
            length = Length;
            breadth = Breadth;
        }
        public double calculatearea()
        {
            return length * breadth;
        }
    }

}
