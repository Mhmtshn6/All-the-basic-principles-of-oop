using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Encapsulation
    {
        static void Main(string[] args)
        {
            Data d1 = new Data();
            d1.Name = "Admin";
            d1.Age = 30;
        }
    }

    class Data
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
    }
}
