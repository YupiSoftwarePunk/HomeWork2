using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    public class State
    {
        private int _residents;
        private string _name;
        private double _square;


        public State(int residents, string name, double square)
        {
            _residents = residents;
            _name = name;
            _square = square;
        }

        public static string operator+(State a, State b)
        {
            return $"Общее кол-во жителей: {a._residents + b._residents}, общая площадь: {a._square + b._square}";
        }

        public static bool operator<(State a, State b)
        {
            if (a._residents == b._residents)
            {
                return a._square < b._square;
            }
            else
            {
                return a._residents < b._residents;
            }
        }
        public static bool operator>(State a, State b)
        {
            if (a._residents == b._residents)
            {
                return a._square > b._square;
            }
            else
            {
                return a._residents > b._residents;
            }
        }


        public static bool operator >=(State a, double square)
        {
            return a._square >= square;
        }
        public static bool operator <=(State a, double square)
        {
            return a._square <= square;
        }

        public static bool operator >=(State a, int residents)
        {
            return a._residents >= residents;
        }
        public static bool operator <=(State a, int residents)
        {
            return a._residents <= residents;
        }
    }
}
