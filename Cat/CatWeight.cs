using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    public static class CatWeight
    {
        private static int lowWeight = 1;
        private static int mediumWeight = 3;
        private static int bigWeight = 5;

        public static string WhatShape(Cat a)
        {
            if (a.weight < lowWeight)
            {
                return "Котик очень худой";
            }
            else if (a.weight >= lowWeight && a.weight < mediumWeight)
            {
                return "Котик худой";
            }
            else if (a.weight >= mediumWeight && a.weight < bigWeight)
            {
                return "Котик полноват";
            }
            else 
            {
                return "Котик полный";
            }
        }

    }
}
