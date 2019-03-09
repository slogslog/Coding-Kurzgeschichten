using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Die_vier_Jahreszeiten___Enums
{
    enum Jahreszeit
    {
        Frühling, // = 0
        Sommer,   // = 1
        Herbst,
        Winter
    }

    class Program
    {
        // Ausgabe des Jahreszeitenbeginns im heurigen Jahr (astronomisch)
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Gib eine Jahreszeit ein: ");
                Jahreszeit jz = (Jahreszeit)Enum.Parse(typeof(Jahreszeit), Console.ReadLine());

                // Umwandlung vom Enum zu einer Zahl
                int nummer = (int)jz;
                Console.WriteLine($"{jz} ist die {nummer + 1}. Jahreszeit.");

                // Umwandlung von einer Zahl zum Enum
                Jahreszeit nächste = (Jahreszeit)((nummer + 1) % 4);
                Console.WriteLine($"Die nächste Jahreszeit ist {nächste}.");

                DateTime beginnDatum = Beginn(jz);
                Console.WriteLine($"Der {jz} beginnt heuer am {beginnDatum.ToString("d. MMMM yyyy")}.");

                Console.Write("Beenden mit Escape" + Environment.NewLine);
            }
            while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }

        // Frühlingsbeginn: 21. März
        // Sommerbeginn: 21. Juni
        // Herbstbeginn: 23. September
        // Winterbeginn: 21. Dezember (des aktuellen Jahres)
        static DateTime Beginn(Jahreszeit jahreszeit)
        {
            switch (jahreszeit)
            {
                case Jahreszeit.Frühling:
                    return new DateTime(DateTime.Now.Year, 3, 21);
                case Jahreszeit.Sommer:
                    return new DateTime(DateTime.Now.Year, 6, 21);
                case Jahreszeit.Herbst:
                    return new DateTime(DateTime.Now.Year, 9, 23);
                case Jahreszeit.Winter:
                default:
                    return new DateTime(DateTime.Now.Year, 12, 21);
            }
        }
    }
}
