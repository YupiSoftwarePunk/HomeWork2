using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    public static class Empire
    {
        private static int _residents = 300000;
        private static double _square = 900000;


        public static string IsEmpire(State a)
        {
            if (a >= _residents && a >= _square)
            {
                return "Это государство – империя";
            }
            else
            {
                return "Это государство – не империя";
            }
        }
    }
}
