using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day09_task
{
    struct Circle
    {

        public double Radius { get; set; }
        public string Color { get; set; }

        public Circle(double rad, string color)
        {
            Radius = rad;
            Color = color;
        }

        public static bool operator ==(Circle C1, Circle C2)
        {
            return C1.Radius == C2.Radius && C1.Color == C2.Color;
        }

        public static bool operator !=(Circle C1, Circle C2)
        {
            return !(C1 == C2);
        }

        public override bool Equals(object obj)
        {
            if (obj is Circle C)
                return Radius == C.Radius && Color == C.Color;

            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Radius, Color);
        }
    }
}
