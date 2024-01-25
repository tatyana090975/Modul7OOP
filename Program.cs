using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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
        
    
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.ReadKey();
        }

    }
}
