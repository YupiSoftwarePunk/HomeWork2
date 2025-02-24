using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Figure6
    {
        public static double P(double a)
        {
            return a * 4;
        }

        public static double P(double a, double b)
        {
            return 2 * (a + b);
        }

        public static double P(double a, double b, double c)
        {
            return a + b + c;
        }

        public static double P(int a, int b, int c)
        {
            return a + b + 2 * c;
        }
    }
}
