using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    public class Cat
    {
        private string name;
        private string breed;
        private string birthDate;
        public double weight;

        public Cat(string name, string breed, string birthDate, double weight)
        {
            this.name = name;
            this.breed = breed;
            this.birthDate = birthDate;
            this.weight = weight;
        }

        public static bool operator <(Cat a, Cat b)
        {
            return a.weight < b.weight;
        }

        public static bool operator >(Cat a, Cat b)
        {
            return a.weight > b.weight;
        }

        public static string operator *(Cat a, Cat b)
        {
            if (a.breed == b.breed)
            {
                return "Селекция возможна\n";
            }
            else
            {
                return "Селекция невозможна\n";
            }
        }
    }
}
