using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Week12
{
    internal abstract class Quadrailateral : Shape
    {


        public double Length { get; set; }
        public double Width { get; set; }

        public Quadrailateral()
        {
            name = "Quadrailateral";


        }

        public override double GetArea()
        {
            Console.WriteLine($"[{name}] Get Area:");
            return Length * Width;
        }
    }
}
