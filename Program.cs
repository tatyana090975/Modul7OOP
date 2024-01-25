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
        public static int MaxValue = 200;
    }

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
