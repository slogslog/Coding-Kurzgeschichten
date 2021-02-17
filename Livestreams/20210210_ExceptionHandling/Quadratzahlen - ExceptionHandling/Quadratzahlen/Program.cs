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

            while (true)
            {
                try
                {
                    Console.Write("Gib die Anzahl der Quadratzahlen ein: ");
                    anzahl = int.Parse(Console.ReadLine());
                    break;  // Verlasse die Schleife
                }
                catch(FormatException ex)
                {
                    //Console.Out.WriteLine(); -> Console.WriteLine();
                    //Console.Error.WriteLine();
                    //Console.In.ReadLine();   -> Console.ReadLine();
                    Console.Error.WriteLine("Du hast keine Zahl eingegeben");
                    Console.Error.WriteLine("Details: " + ex.Message);
                    //Console.WriteLine(ex.StackTrace);
                }
                catch(OverflowException ex)
                {
                    Console.Error.WriteLine("Die eingegebene Zahl war zu groß oder zu klein.");
                    Console.Error.WriteLine("Details: " + ex.Message);
                }
                catch(ArgumentNullException)
                {
                    Console.Error.WriteLine("Es wurde null eingegeben.");
                }
            }

            for (i = 1; i <= anzahl; i++)
            {
                Console.WriteLine(i + "² = " + i * i);
            }

            Console.ReadKey();
        }
    }
}
