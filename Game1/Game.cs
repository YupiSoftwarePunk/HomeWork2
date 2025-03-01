using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    public class Game
    {
        private string name;
        public int averageGamers;
        public int maxGamers;
        public double rating;
        private double maxRating;
        private double minRating;

        public Game(string name, int averageGamers, int maxGamers, double rating, double maxRating, double minRating)
        {
            this.name = name;
            this.averageGamers = averageGamers;
            this.maxGamers = maxGamers;
            this.rating = rating;
            this.maxRating = maxRating;
            this.minRating = minRating;
        }

        public static Game operator++(Game a)
        {
            a.rating += 0.1;
            a.maxRating = 10;
            return a;
        }
        public static Game operator--(Game a)
        {
            a.rating -= 0.1;
            a.minRating = 0;
            return a;
        }

        public static string operator >(Game a, Game b)
        {
            if ( a.averageGamers >= b.averageGamers && a.maxGamers >= b.maxGamers && a.rating >= b.rating)
            {
                return a.name;
            }
            else
            {
                return b.name;
            }
        }
        public static string operator <(Game a, Game b)
        {
            if (a.averageGamers <= b.averageGamers && a.maxGamers <= b.maxGamers && a.rating <= b.rating)
            {
                return b.name;
            }
            else
            {
                return a.name;
            }
        }
        public static string operator==(Game a, Game b)
        {
            if (a.averageGamers == b.averageGamers && a.maxGamers == b.maxGamers && a.rating == b.rating)
            {
                return a.name;
            }
            else
            {
                return b.name;
            }
        }
        public static string operator !=(Game a, Game b)
        {
            if (a.averageGamers != b.averageGamers && a.maxGamers != b.maxGamers && a.rating != b.rating)
            {
                return a.name;
            }
            else
            {
                return b.name;
            }
        }
    }
}
