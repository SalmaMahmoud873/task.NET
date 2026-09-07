using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_day02
{
     class Child : Parent
    {
        public int Z;
        public Child(int x , int y , int z) : base(x,y)
        {
            Z = z;
        }
        public override int Product()
        {
            return X * Y * Z;
        }

        public override string ToString()
        {
            return $"({X},{Y},{Z})";
        }
    }
}
