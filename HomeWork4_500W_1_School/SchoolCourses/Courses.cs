using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4_500W_1_School.SchoolCourses
{
    public class Courses 
    {
        public string courseName;


        public Courses(string courseName)
        {
           this.courseName = courseName;
        }

        public virtual void Print()
        {
            Console.WriteLine($"Course info:{courseName}");
        }
    }
}
