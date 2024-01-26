using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Modul7OOP
{
    class Obj
    {
        public string Name;
        public string Description;
        public static string Parent;
        public static int DaysInWeek;
        public static int MaxValue;

        static Obj()
        {
            string Parent = "System.Object";
            int DaysInWeek = 7;
            int MaxValue = 2000;
        }            
    }

    static class IntExtensions
    {
        public static int GetNegative(this int value)
        {
            if (value > 0) { return -value; }
            else return value;
        }

        public static int GetPositive(this int value)
        {
            if (value < 0) { return -value; }
            else return value;
        }
    }    

    class Program
    {
        
        static void Main(string[] args)
        {
            int num1 = 7;
            int num2 = -13;
            int num3 = 0;

            Console.WriteLine(num1.GetNegative()); //-7
            Console.WriteLine(num1.GetPositive()); //7
            Console.WriteLine(num2.GetNegative()); //-13
            Console.WriteLine(num2.GetPositive()); //13
            Console.WriteLine(num3.GetNegative()); //0
            Console.WriteLine(num3.GetPositive());

            Console.ReadKey();
        }

    }
}
