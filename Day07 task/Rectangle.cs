using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_day02
{
     class Rectangle : Shape ,IShape 
    {
        public double Width;
        public double Height;

        public double Area
        {
            get { return Width *  Height; }
        }

        public void Draw()
        {
            Console.WriteLine("Drawing a Rectangle");
        }

        public override void draw()
        {
            Console.WriteLine("Drawing Rectangle");
        }

        public override double calcArea()
        {
            return Width * Height;
        }
    }
}
