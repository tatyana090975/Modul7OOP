using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul7OOP
{
    class Helper
    {
        public static void Swap(int num1, int num2)
        {
            int num = num1;
            num1 = num2;
            num2 = num;
            //Console.WriteLine($"num1 = {num1}, num2 = {num2}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 3;
            int num2 = 58;

            Helper.Swap(num1, num2);

            Console.WriteLine(num1); 
            Console.WriteLine(num2); 

            Console.ReadKey();
        }

    }
}
