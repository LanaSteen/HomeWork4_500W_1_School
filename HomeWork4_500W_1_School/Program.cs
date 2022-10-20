using HomeWork4_500W_1_School.People;
using HomeWork4_500W_1_School.SchoolCourses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4_500W_1_School
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Courses courses = new Courses("AA11");
            //courses.Print();

            //Console.WriteLine();
            
            //Classes classes = new Classes("A1", "AA11");
            //classes.Print();
            //Console.WriteLine();

            //Person person = new Person("John","Student", "A1", "AA11");
            //person.Print();
            //Console.WriteLine();

            Students students = new Students("John", "Student", "A1", "AA11", 1);
            students.Print();
            Console.WriteLine();

            Teachers teachers = new Teachers("Emilia", "Teacher", "A1", "AA11");
            teachers.Print();
        }



    }
}
