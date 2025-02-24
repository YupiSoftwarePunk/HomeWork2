using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Array2
    {
        public static double MaxNum(int[] numbers)
        {
            int maxValue = int.MinValue;
            for (int i = 0; i < numbers.Length; i++)
            if (numbers[i] > maxValue)
            {
                maxValue = numbers[i];
            }
            return maxValue;
        }

        public static double MaxNum(double[] numbers)
        {
            double maxValue = double.MinValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > maxValue)
                {
                    maxValue = numbers[i];
                }
            }
            return maxValue;
        }
    }
}
