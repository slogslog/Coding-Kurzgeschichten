using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methoden_mit_einem_Rückgabewert
{
    class Program
    {
        // Funktionen sind Methoden die einen oder mehrere Werte zurückgeben
        static double BerechnePotenz(double z, int exponent )
        {
            double p = 1;

            for ( int i = 1; i <= exponent; i = i + 1 )
            {
                p = p * z;
            }

            return p;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Gib eine Zahl ein: ");
            double zahl = double.Parse(Console.ReadLine());

            // TODO: Berechne die dritte Potenz der Zahl, also 1 * zahl * zahl * zahl
            double potenz3 = BerechnePotenz(zahl, 3);

            // TODO: Berechne die fünfte Potenz der Zahl, also 1 * zahl * zahl * zahl * zahl * zahl
            double potenz5 = BerechnePotenz(zahl, 5);

            Console.WriteLine($"Die dritte Potenz ist {potenz3}."); // interpolated strings
            Console.WriteLine("Die fünfte Potenz ist " + potenz5 + ".");

            double[] zahlen = { -1, Math.PI, Math.E, 10 };

            // Für jede dieser 4 Zahlen möchte ich die Potenzen von 1 bis 5 ausgeben.
            for ( int i = 0; i < zahlen.Length; i = i + 1)
            {
                // zahlen[i] ist nacheinander -1, dann Math.PI, dann Math.E und dann 10
                Console.WriteLine($"Die Zahl ist {zahlen[i]}.");

                for ( int exponent = 1; exponent <= 5; exponent = exponent + 1 )
                {
                    // -1^3 = das Ergebnis
                    Console.WriteLine($"{zahlen[i]}^{exponent} = {BerechnePotenz(zahlen[i], exponent)}");
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
