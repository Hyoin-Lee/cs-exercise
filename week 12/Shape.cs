using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Week12
{
    internal class Shape
    {

        public string name;


        public Shape() 
        {
        }


        public virtual double GetArea()
        {
            Console.WriteLine($"[{name}] Get Area:");
            return 0;
        }

    }
}
