using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_08
{
     class Triangle : GeometricShape
    {
        public override double CalculateArea()
        {
            return 0.5 * Dim1 * Dim2;
        }

        public override double Perimeter
        {
            get
            {
                return Dim1 + Dim2;
            }
        }
    }
}
