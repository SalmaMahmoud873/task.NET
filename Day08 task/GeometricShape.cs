using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_08
{
    abstract class GeometricShape
    {
        public double Dim1 { get; set; }
        public double Dim2 { get; set; }

        public abstract double CalculateArea();

        public abstract double Perimeter { get; }
    }
}
