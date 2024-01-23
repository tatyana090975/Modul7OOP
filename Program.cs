using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul7OOP
{
    class A
    {
        public virtual void Display()
        {
            Console.WriteLine("A");
        }
    }
    class B : A
    {
        public new void Display()
        {
            Console.WriteLine("B");
        }
    }

    class D : A
    {
        public new void Display()
        {
            Console.WriteLine("D");
        }
    }

    class C : A
    {
        public override void Display()
        {
            Console.WriteLine("C");
        }
    }

    class E : C
    {
        public new void Display()
        {
            Console.WriteLine("E");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();
            C c = new C();

            a.Display();    // метод класса A
            b.Display();    // метод класса B
            ((A)b).Display();   // метод класса B

            c.Display();    // метод класса C
            ((A)c).Display();   // метод класса B
            ((B)c).Display();	// метод класса B

            Console.ReadKey();
        }

    }
}
