using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    public class Ingredient
    {
        private string _name;
        private string _effect;
        private double _price;

        public Ingredient(string name, string effect, double price)
        {
            _name = name;
            _effect = effect;
            _price = price;
        }

        public static bool operator<(Ingredient a, Ingredient b)
        {
            return a._price < b._price;
        }
        public static bool operator >(Ingredient a, Ingredient b)
        {
            return a._price > b._price;
        }
        public static bool operator ==(Ingredient a, Ingredient b)
        {
            return a._price == b._price;
        }
        public static bool operator !=(Ingredient a, Ingredient b)
        {
            return a._price != b._price;
        }

        public static string operator+(Ingredient a, Ingredient b)
        {
            double sum = (a._price + b._price) * 3;
            string effects = a._effect + b._effect;
            return $"Зелье стоимостью: {sum}, с эффектами: {effects}";
        }

        public static bool operator>=(Ingredient a, double price)
        {
            return a._price >= price;
        }
        public static bool operator <=(Ingredient a, double price)
        {
            return a._price <= price;
        }
        public static bool operator >(Ingredient a, double price)
        {
            return a._price > price;
        }
        public static bool operator <(Ingredient a, double price)
        {
            return a._price < price;
        }
    }
}
