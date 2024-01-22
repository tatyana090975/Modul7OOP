using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul7OOP
{
    class BaseClass
    {
        protected string Name;

        public BaseClass(string name)
        {
            Name = name;
        }

        public virtual void Display()
        {
            Console.WriteLine("Метод класса BaseClass");
        }
    }

    class DerivedClass : BaseClass
    {
        public string Description;

        public int Counter;

        public DerivedClass(string name, string description): base(name)
        {
            Description = description;
        }

        public DerivedClass(string name, string description, int counter): base(name)
        {
            Description = description;
            Counter = counter;
        }

        public override void Display()
        {
            Console.WriteLine("Метод класса DerivedClass");
        }
    }



    class Obj
    {
        private string name;
        private string owner;
        private int length;
        private int count;

        public Obj(string name, string ownerName, int objLength, int count)
        {
            this.name = name;
            owner = ownerName;
            length = objLength;
            this.count = count;
        }
    }

    class SmartHelper
    {
        private string name;

        public SmartHelper(string name)
        {
            this.name = name;
        }

        public void Greetings(string name)
        {
            Console.WriteLine("Привет, {0}, я интеллектуальный помощник {1}", name, this.name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SmartHelper helper = new SmartHelper("Олег");
            helper.Greetings("Грег");

            Console.ReadKey();
        }

    }
}
