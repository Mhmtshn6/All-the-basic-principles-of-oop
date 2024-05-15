using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Inheritance
    {
        static void Main(string[] args)
        {
            TeachersInformation teacher1 = new TeachersInformation();
            teacher1.Name = "Admin";
            teacher1.Age = 41;

            StudenInformation student1 = new StudenInformation();
            student1.Name = "Student1";
            student1.Age = 13;
            student1.StudentNumber = 103;
        }
    }
    class Information
    {
        public string Name;
        public int Age;
    }
    class TeachersInformation : Information { }

    class StudenInformation : Information
    {
        public int StudentNumber;
    }
}