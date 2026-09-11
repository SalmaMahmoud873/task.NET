using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_08
{
    abstract class Shape
    {
        public abstract double GetArea();
        public void Display()
        {
            Console.WriteLine("this is a shape ");
        }
    }
}
