using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_08
{
     class Shape1 : IComparable<Shape1>
    {
        public string Name { get; set; }
        public double Area { get; set; }

        public Shape1(string n, double area)
        {
            Name = n;
            Area = area;
        }

        public int CompareTo(Shape1 other)
        {
            return Area.CompareTo(other.Area);
        }
    }
}
