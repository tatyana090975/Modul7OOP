using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Modul7OOP
{
    
    abstract class Car<TEngine> 
        where TEngine : Engine
    {
        public TEngine Engine;
        public virtual void ChangePart<TPart>(TPart newPart) where TPart : CarPart {}
               
    }

    class ElectricCar : Car<ElectricEngine> 
    {
        public override void ChangePart<TPart>(TPart newPart)
        {
            base.ChangePart(newPart);
        }
    }
    
    class GasCar : Car<GasEngine> 
    {
        public override void ChangePart<TPart>(TPart newPart)
        {
            base.ChangePart(newPart);
        }
    }

    abstract class Engine { }
    
    class ElectricEngine : Engine { }

    class GasEngine : Engine { }

    abstract class CarPart { }
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
