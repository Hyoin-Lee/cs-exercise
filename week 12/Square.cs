using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Week12
{
    internal class Square : Quadrailateral
    {

        public Square(double length)
        {
            name = "Square";
            Length = length;
            Width = length;
        }

        public override double GetArea()
        {
            Console.WriteLine($"[{name}] Get Area:");
            return Length * Length;
        }
    }



}
