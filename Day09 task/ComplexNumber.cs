using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day09_task
{
    internal class ComplexNumber
    {
        public int Real {  get; set; }
        public int Imaginary {  get; set; }

        public ComplexNumber(int real , int imag)
        {
            Real = real;
            Imaginary = imag;
        }
        public static ComplexNumber operator *(ComplexNumber C1, ComplexNumber C2)
        {
            return new ComplexNumber(
                C1.Real * C2.Real - C1.Imaginary * C2.Imaginary,
                C1.Real * C2.Imaginary + C1.Imaginary * C2.Real
            );
        }
        public override string ToString()
        {
            return $"{Real} + {Imaginary}i";
        }
    }
}
