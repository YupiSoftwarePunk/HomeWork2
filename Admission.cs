using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    public static class Admission
    {
        private static double passingGrade = 4.5;

        public static bool IsPass(Student student)
        {
            return student > passingGrade;
        }
    }
}

