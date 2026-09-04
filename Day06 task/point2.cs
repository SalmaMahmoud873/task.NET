using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_day01_task
{
    internal class point2
    {
        public int X;
        public int Y;

        public point2(int x)
        {
            X = x;
            Y = 0;
        }

        public point2(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return $"(X: {X},Y: {Y})";
        }
    }
   
}
