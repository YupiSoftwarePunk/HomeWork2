using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    public static class PopularGame
    {
        private static double rating = 8.5;
        private static int averageGamers = 1000;
        private static int maxGamers = 10000;

        public static bool IsGamePopular(Game a)
        {
            return a.rating >= rating && a.averageGamers >= averageGamers && a.maxGamers >= maxGamers;
        }
    }
}
