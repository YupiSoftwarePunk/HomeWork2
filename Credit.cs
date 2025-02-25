using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Credit
    {
        private string FIO;
        private double sum;
        private static double percent = 15;

        public Credit(string fIO, double sum)
        {
            FIO = fIO;
            this.sum = sum;
        }

        public double GetPercent()
        {
            return percent * sum / 100;
        }

        public double GetSum()
        {
            return sum;
        }

        public static Credit operator-(Credit obj, Credit obj2)
        {
            obj.sum += percent * obj.sum / 100;
            obj2.sum += percent * obj.sum / 100;
            return obj - obj2;
        }

        public static Credit operator +(Credit obj, Credit obj2)
        {
            obj.sum += percent * obj.sum / 100;
            obj2.sum += percent * obj.sum / 100;
            return obj + obj2;
        }
    }
}
