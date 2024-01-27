using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Modul7OOP
{
    

    class Program
    {
        class Order<T>
        {
            public T Number;

            public string Description;

        }
        
        static void Main(string[] args)
        {
            Order<int> order1 = new Order<int>();
            order1.Number = 1;
           
            Console.ReadKey();
        }

    }
}
