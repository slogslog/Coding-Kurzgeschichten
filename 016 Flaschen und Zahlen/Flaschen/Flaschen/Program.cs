using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Flasche a = new Flasche();
            Flasche b = a;
            Console.WriteLine($"Vorher:  a={a} b={b}");
            a.WirdAusgetrunken();
            Console.WriteLine($"Nachher: a={a} b={b}");

            Console.ReadKey();
        }
    }
}
