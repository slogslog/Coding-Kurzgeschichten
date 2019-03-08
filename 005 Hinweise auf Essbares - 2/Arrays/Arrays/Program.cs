using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int anzahl = 3;
            int[] zahlen = new int[anzahl];

            Random rnd = new Random();
            for (int i = 0; i < anzahl; i++)
            {
                zahlen[i] = rnd.Next(1, 11);
            }

            string s = String.Join(", ", zahlen);
            Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
