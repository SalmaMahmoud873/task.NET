using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_08
{
     class Robot : IWalkable
    {
        void IWalkable.walk()
        {
            Console.WriteLine("Robot walks using IWalkable ");
        }
        public void walk()
        {
            Console.WriteLine("Robot walks normally ");
        }
    }
}
