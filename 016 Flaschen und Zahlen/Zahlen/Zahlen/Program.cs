using System;

namespace Zahlen
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = a;
            Console.WriteLine($"Vorher:  a={a} b={b}");
            a = 0;
            Console.WriteLine($"Nachher: a={a} b={b}");

            Console.ReadKey();
        }
    }
}
