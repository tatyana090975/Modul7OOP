using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Modul7OOP
{
    
    class Car<T1> 
        where T1 : Engine
    {
        public T1 Engine;
        public virtual void ChangePart<T2>(T2 newPart) where T2 : CarPart {}

        
    }

    class Engine { }
    
    class ElectricEngine : Engine { }

    class GasEngine : Engine { }

    class CarPart { }
    class Battery : CarPart { }

    class Differential : CarPart { }

    class Wheel : CarPart { }

    class Program
    {
       
        
        static void Main(string[] args)
        {
            
           
            Console.ReadKey();
        }

    }
}
