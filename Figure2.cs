using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    public static class Figure2
    {
        public static double Volume(double r)
        {
            return (4 / 3) * (Math.PI * Math.Pow(r, 3));
        }

        public static double Volume(double r, double h)
        {
            return Math.PI * Math.Pow(r, 2) * h;
        }
    }
}
