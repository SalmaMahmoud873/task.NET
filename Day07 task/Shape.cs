using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_day02
{
    abstract class Shape
    {
        public virtual void draw()
        {
            Console.WriteLine("Drawing shape");
        }
        public abstract double calcArea();
    }
}
