using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Modul7OOP
{
    class Record<T1, T2>
    {
        public T1 Id;
        public T2 Note;
        public DateTime Date;
    }
    class Car<T>
    {
        public T Engine = default(T); //значение по умолчанию null для ссылочных типов и 0 для значимых типов
    }
    
    class ElectricEngine
    {

    }

    class GasEngine
    {

    }

    class Program
    {
       
        
        static void Main(string[] args)
        {
            
           
            Console.ReadKey();
        }

    }
}
