using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_day01_task
{
     class TypeA
    {
        private int F = 10;
        internal int G = 20;
        public int H = 30;

        public void ShowinClass()
        {
            Console.WriteLine(F);
            Console.WriteLine(G);
            Console.WriteLine(H);
        }
    }
}
