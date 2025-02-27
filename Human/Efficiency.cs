using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    static public class Efficiency
    {
        private static int minAge = 17;
        private static int maxAge = 70;

        public static bool IsEfficiency(Human a)
        {
            return a.age > minAge && a.age < maxAge;
        }
    }
}
