using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4_500W_1_School.SchoolCourses
{
    public class Classes : Courses
    {
        public string className;

        public Classes(string className, string courseName) : base(courseName)
        {
            this.className = className;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Class info:{className}");
        }
    }

    //public enum ClassType
    //{
    //    A1
    //        /*, A2, A3, A4,
    //    B1, B2, B3, B4,
    //    C1, C2, C3, C4,*/

    //}
}
