using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week12
{
    internal class Rectangle : Quadrailateral
    {

        public Rectangle(double length, double width)
        {
            name = "Rectangle";
            Length = length;
            Width = width;

        }


        public override double GetArea()
        {
            Console.WriteLine($"[{name} Get Area:");
            return Length * Width;
        }
        


    }
}
