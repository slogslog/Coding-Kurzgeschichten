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
            bool istEineZahl;
            string eingabe;

            //istEineZahl = int.TryParse("Pizza", out anzahl);
            //Console.WriteLine(istEineZahl + " zahl=" + anzahl) ;
            //Console.ReadKey();



            //anzahl = int.Parse(Console.ReadLine());
            //string eingabe = Console.ReadLine();
            // if ( ... == false ) -> if ( !... )
            Console.Write("Gib die Anzahl der Quadratzahlen ein: ");     
            while ( !int.TryParse(eingabe = Console.ReadLine(), out anzahl) )
            {
                Console.Error.WriteLine($"Deine Eingabe war \"{eingabe}\". Du musst eine Zahl eingeben!");
                Console.Write("Gib die Anzahl der Quadratzahlen ein: ");
            }

            for (i = 1; i <= anzahl; i++)
            {
                Console.WriteLine(i + "² = " + i * i);
            }


            Console.ReadKey();
        }
    }
}
