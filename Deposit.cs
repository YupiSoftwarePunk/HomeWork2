
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    public class Deposit
    {
        private string FIO;
        private double sum;
        private static double percent = 20;

        public Deposit(string fio, double initialSum) 
        {
            FIO = fio;
            sum = initialSum;
        }

        public double GetPercent()
        {
            return percent;
        }

        public double GetSum()
        {
            return sum;
        }

        public static Deposit operator ++(Deposit obj)
        {
            obj.sum += percent * obj.sum / 100;
            return obj;
        }

        public static Deposit operator --(Deposit obj)
        {
            obj.sum -= percent * obj.sum / 100;
            return obj;
        }
    }
}
