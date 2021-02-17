using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadratzahlen
{
    class Program
    {
        static void Main(string[] args)
        {
            int anzahl, i;

            Console.Write("Gib die Anzahl der Quadratzahlen ein: ");

            anzahl = int.Parse(Console.ReadLine());

            for ( i = 1; i <= anzahl; i++ )
            {
                Console.WriteLine(i + "² = " + i*i);
            }

            Console.ReadKey();
        }
    }
}
