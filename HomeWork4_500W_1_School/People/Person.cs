using HomeWork4_500W_1_School.SchoolCourses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4_500W_1_School.People
{
    public class Person : Classes
    {
        public string Name;
        public string type;
        public Person(string Name, string type, string className, string courseName) : base(className, courseName)
        {
            this.Name = Name;
            this.type = type;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Person info:{Name} Type: {type}");
        }

        
    }

    //public enum PersonType
    //{
    //    Student,
    //    Teacher
    //}

}
