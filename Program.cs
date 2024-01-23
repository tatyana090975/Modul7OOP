using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul7OOP
{
    class Vector
    {
        public int X;
        public int Y;

        public Vector Add(Vector second)
        {
            return new Vector
            {
                X = this.X + second.X,
                Y = this.Y + second.Y
            };
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Vector a = new Vector { X = 3, Y = 5 };
            Vector b = new Vector { X = 7, Y = 13 };

            Vector c = a.Add(b);

            Console.WriteLine($"{c.X}, {c.Y}");

            Console.ReadKey();
        }

    }
}
