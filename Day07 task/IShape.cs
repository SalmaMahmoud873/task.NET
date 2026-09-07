using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_day02
{
     interface IShape
    {
        double Area
        {
            get;
        }
        void Draw();
        void PrintDetails()
        {
            Console.WriteLine($"Area = {Area}");
        }
    }
}
