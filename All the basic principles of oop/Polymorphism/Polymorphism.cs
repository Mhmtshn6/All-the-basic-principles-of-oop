using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Polymorphism
    {
        static void Main(string[] args)
        {
            Square s1 = new Square();
            Circle c1 = new Circle();

            s1.Draw();
            c1.Draw();
        }
    }
    class shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Draw a Shape");
        }
    }

    class Square : shape { }

    class Circle : shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a Circle");
        }
    }
}
