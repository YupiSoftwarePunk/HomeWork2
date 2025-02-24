
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HomeWork2
{
    public class Number1
    {
        public static double PrintMax(double a, double b)
        {
            return a > b ? a : b;
        }
        public static double PrintMax(double a, double b, double c)
        {
            return Number1.PrintMax(Number1.PrintMax(a, b), c);
        }
        public static double PrintMax(double a, double b, double c, double d)
        {
            return Number1.PrintMax(Number1.PrintMax(a, b, c), d);
        }
        public static double PrintMax(double a, double b, double c, double d, double e)
        {
            return Number1.PrintMax(Number1.PrintMax(a, b, c, d), e);
        }
    }
}
