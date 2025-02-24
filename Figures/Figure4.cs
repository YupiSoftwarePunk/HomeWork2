using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    public static class Figure4
    {
        public static double Square(double r)
        {
            return 4 * Math.PI * Math.Pow(r, 2);
        }

        public static double Square(double r, double h)
        {
            return 2 * Math.PI * r * (r + h);
        }
    }
}
