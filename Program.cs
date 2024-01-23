using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul7OOP
{
    abstract class ComputerPart
    {
        public abstract void Work();
    }

    class Processor : ComputerPart
    {
        public override void Work()
        {
            
        }
    }

    class MotherBoard : ComputerPart
    {
        public override void Work()
        {
            
        }
    }

    class GraphicCard : ComputerPart
    {
        public override void Work()
        {
            
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
