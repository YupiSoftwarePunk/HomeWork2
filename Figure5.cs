using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    public static class Figure5
    {
        public static double Sq(double a)
        {
            return a * a;
        }
        public static double Sq(double a, double b)
        {
            return a * b;
        }

        public static double Sq(int a, int b)
        {
            return a * b / 2;
        }

        public static double Sq(double a, double b, double h)
        {
            return (a + b) * h / 2;
        }

    }
}
