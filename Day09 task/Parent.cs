using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day09_task
{
    internal class Parent
    {
        public int X { get; set; }
        public int Y { get; set; }

        public virtual double Salary { get; set; }

        public Parent(int _X, int _Y)
        {
            X = _X;
            Y = _Y;
        }

        public override string ToString()
        {
            return $"( {X} , {Y} )";
        }

        public int Product()
        {
            return X * Y;
        }

        public virtual int Sum()
        {
            return X + Y;
        }
    }
}
