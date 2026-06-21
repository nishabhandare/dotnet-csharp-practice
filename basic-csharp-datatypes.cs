using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp47
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char c = 'A';
            int i = 23;
            short s = 45;
            long l = 2134;
            uint ui = 43;
            ushort us = 23;
            ulong ul = 345678;
            double d = 3.45678234;
            float f = 3.56576867f;
            decimal de=354.5m;

            Console.WriteLine("hello world!");
            Console.WriteLine("character value is "+c+" and its data type is " + c.GetType());
            Console.WriteLine("integer value is " + i + " and its data type is " + i.GetType());
            Console.WriteLine("short value is " + s + " and its data type is " + s.GetType());
            Console.WriteLine("long value is " + l + " and its data type is " + l.GetType());
            Console.WriteLine("unsigned integer value is " + ui + " and its data type " + ui.GetType());
            Console.WriteLine("unsigned short value is " + us + " and its data type " + us.GetType());
            Console.WriteLine("unsigned long value is " + ul + " and its  data type is " + ul.GetType());
            Console.WriteLine("double value is " + d + " and its data type is " + d.GetType());
            Console.WriteLine("float value is " + f + " and its data type is " + f.GetType());
            Console.WriteLine("decimal value is " + de + " and its data type is " + de.GetType());

        }
    }
}
