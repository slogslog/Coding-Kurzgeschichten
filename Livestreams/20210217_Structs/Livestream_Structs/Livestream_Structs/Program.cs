using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livestream_Structs
{
    // User-defined Datatype
    struct Spielerdaten
    {
        public string name;
        public int missionen;
        public int goldstuecke;
    }

    class Program
    {
        static void Main(string[] args)
        {
            const int maxAnzahl = 100;
            Spielerdaten[] spieler = new Spielerdaten[maxAnzahl];

            int i, anzahl;
            i = 0;
            anzahl = 0;

            #region Eingabe aller Daten
            Console.Write("Gib den Namen des " + (i + 1) + ". ten Spielers ein: ");
            spieler[i].name = Console.ReadLine();

            //while (!String.IsNullOrEmpty(namen[i]))
            while (spieler[i].name != String.Empty) // das negierte Stoppkriterium
            {
                Console.Write("Gib die erfüllten Missionen von " + spieler[i].name + " ein: ");
                spieler[i].missionen = int.Parse(Console.ReadLine());

                Console.Write("Gib die Goldstück von " + spieler[i].name + " ein: ");
                spieler[i].goldstuecke = int.Parse(Console.ReadLine());

                anzahl = anzahl + 1;
                i = i + 1;

                Console.Write("Gib den Namen des " + (i + 1) + ". ten Spielers ein: ");
                spieler[i].name = Console.ReadLine();
            }
            #endregion

            #region Ausgabe aller Spieler
            Console.WriteLine("\nAlle Spieler");
            for (i = 0; i < anzahl; i = i + 1)
            {
                Console.WriteLine(spieler[i].name + " hat " + spieler[i].missionen +
                    " Missionen erfüllt und noch " + spieler[i].goldstuecke + " Goldstücke über.");
            }
            #endregion

            #region Suche des Spielers mit den meisten Missionen
            Spielerdaten spielerMitMaxMissionen = spieler[0];

            for (i = 1; i < anzahl; i = i + 1)
            {
                if (spieler[i].missionen > spielerMitMaxMissionen.missionen)
                {
                    spielerMitMaxMissionen = spieler[i];
                }
            }

            Console.WriteLine(spielerMitMaxMissionen.name + " hat die meisten Missionen erfüllt (" +
                spielerMitMaxMissionen.missionen + "). Er hat noch " + 
                spielerMitMaxMissionen.goldstuecke + " Goldstücke.");
            #endregion

            Console.ReadKey();
        }
    }
}
