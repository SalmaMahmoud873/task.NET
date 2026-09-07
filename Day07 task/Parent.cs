using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_day02
{
     class Parent
    {
        public int X;
        public int Y;

        public Parent(int x, int y)
        {
            X = x;
            Y = y;
        }

        public virtual int Product()
        {
            return X * Y;
        }

        public override string ToString()
        {
            return $"({X},{Y})";
        }
    }
}
