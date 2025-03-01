using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    public static class Price
    {
        private static double _lowPrice = 100;
        private static double _midPrice = 500;
        private static double _bigPrice = 1500;


        public static string WhichPrice(Ingredient a)
        {
            if (a < _lowPrice)
            {
                return "Цена очень низкая";
            }
            else if (a >= _lowPrice && a < _midPrice)
            {
                return "Цена низкая";
            }
            else if (a >= _midPrice && a < _bigPrice)
            {
                return "Цена завышена";
            }
            else
            {
                return "Цена слишком высокая";
            }
        }
    }
}
