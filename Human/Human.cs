using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    public class Human
    {
        private string FIO;
        private string sex;
        public int age;
        private string eyesColour;

        public Human(string fIO, string sex, int age, string eyesColour)
        {
            FIO = fIO;
            this.sex = sex;
            this.age = age;
            this.eyesColour = eyesColour;
        }

        public static string operator+(Human a, Human b)
        {
            if (a.eyesColour == "карие" && b.eyesColour == "карие")
            {
                return "карие";
            }
            else if (a.eyesColour == "зеленые" && b.eyesColour == "карие")
            {
                return "карие";
            }
            else if (a.eyesColour == "голубые" && b.eyesColour == "карие")
            {
                return "карие";
            }
            else if (a.eyesColour == "зеленые" && b.eyesColour == "зеленые")
            {
                return "зеленые";
            }
            else if (a.eyesColour == "зеленые" && b.eyesColour == "голубые")
            {
                return "голубые";
            }
            else //if (a.eyesColour == "голубые" && b.eyesColour == "голубые")
            {
                return "голубые";
            }
        }
    }
}
