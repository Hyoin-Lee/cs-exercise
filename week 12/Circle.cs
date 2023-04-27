using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week12
{
    internal class Circle : Quadrailateral
    {

        public int Radius { get; set; }

        public Circle(int radius)
        {
            name = "Circle";
            Radius = radius;

        }

        public override double GetArea()
        {

            return (Radius * Radius) * Math.PI;

        }

    }



}
