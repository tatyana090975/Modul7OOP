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

        public static Vector operator +(Vector a, Vector b)
        {
            return new Vector
            {
                X = a.X + b.X,
                Y = a.Y + b.Y
            };
        }
        /*
        public Vector Add(Vector second)
        {
            return new Vector
            {
                X = this.X + second.X,
                Y = this.Y + second.Y
            };
        }*/
    }

    class Program
    {
        static void Main(string[] args)
        {
            Vector a = new Vector { X = 3, Y = 5 };
            Vector b = new Vector { X = 7, Y = 13 };

            Vector c = a + b;

            Console.WriteLine($"{c.X}, {c.Y}");

            Console.ReadKey();
        }

    }
}
