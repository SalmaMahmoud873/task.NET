using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day09_task
{
    struct Rectangle
    {
        public int Length { get; set; }
        public int Width { get; set; }

        public Rectangle(int l, int w)
        {
            Length = l;
            Width = w;
        }

        public override string ToString()
        {
            return $"Length = {Length}, Width = {Width}";
        }
    }
}
