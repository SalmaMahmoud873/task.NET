using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Day_08
{
     class Rectangle : GeometricShape //: Shape 
    {
        #region part01

        //public double width;
        //public double Height;

        //public Rectangle(double w, double h)
        //{
        //    width = w;
        //    Height = h;
        //}
        //public override double GetArea()
        //{
        //    return width * Height;
        //} 
        #endregion

        public override double CalculateArea()
        {
            return Dim1 * Dim2;
        }

        public override double Perimeter
        {
            get
            {
                return 2 * (Dim1 + Dim2);
            }
        }

    }
}
