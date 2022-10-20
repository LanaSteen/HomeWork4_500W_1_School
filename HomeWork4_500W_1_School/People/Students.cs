using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4_500W_1_School.People
{
    public class Students : Person
    {

        public int id;
        public Students(string Name, string type, string className, string courseName, int id) : base(Name, type, className, courseName)
        {
            this.id = id;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Student ID: {id}");
        }
    }
}
