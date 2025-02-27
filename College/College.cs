using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    public class College
    {
        private string collegeName;
        public int studentCount;
        private int classroomCount;
        public int teachersCount;

        public College(string collegeName, int studentCount, int classroomCount, int teachersCount)
        {
            this.collegeName = collegeName;
            this.studentCount = studentCount;
            this.classroomCount = classroomCount;
            this.teachersCount = teachersCount;
        }

        public static bool operator>(College a, College b)
        {
            if (a.studentCount == b.studentCount)
            {
                return a.classroomCount > b.classroomCount;
            }
            else
            {
                return a.studentCount < b.studentCount;
            }
        }

        public static bool operator<(College a, College b)
        {
            if (a.studentCount == b.studentCount)
            {
                return a.classroomCount < b.classroomCount;
            }
            else
            {
                return a.studentCount < b.studentCount;
            }
        }

    }
}
