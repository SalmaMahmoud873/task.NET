using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_08
{
     class CircleSeries : IShapeSeries
    {
        public int CurrentShapeArea { get; set; }

        private int radius = 0;

        public void GetNextArea()
        {
            radius++;
            CurrentShapeArea = (int)(Math.PI * radius * radius);
        }

        public void ResetSeries()
        {
            radius = 0;
            CurrentShapeArea = 0;
        }
    }
}
