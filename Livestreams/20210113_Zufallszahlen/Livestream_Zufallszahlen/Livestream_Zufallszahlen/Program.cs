using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livestream_Zufallszahlen
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, index, x, y;
            string wort;
            Random rnd = new Random();

            #region Würfeldemo
            // Würfeln von 1 bis 6
            //int zahl;
            //for ( int i = 1; i <= 20; i++ )
            //{

            //    zahl = rnd.Next(1, 6+1);
            //    Console.Write(zahl+ " ");
            //}

            //Console.WriteLine(zahl);
            #endregion

            #region Auswahl von mehreren Alternativen
            // Auswahl eines zufälligen Wortes aus 5 verschiedenen
            //string[] woerter = new string[5];   // Eine Variable die 5 Werte speichern kann.
            //// Und jedes Wort kann ich mit einer Zahl (=Index) abrufen.
            //woerter[0] = "Bauer";
            //woerter[1] = "Dampfschiff";
            //woerter[2] = "Power";
            //woerter[3] = "Professor";
            //woerter[4] = "Desoxyribonukleinsäure";

            // Trick: Es gibt sogenannte Initializer.
            string[] woerter =
            {
                "Bauer",        // [0]
                "Dampfschiff",  // [1]
                "Power",
                "Professor",
                "Desoxyribonukleinsäure",
                "Console",
                "Wort",
                "Liptauersemmel",
                "Livestream"
            };

            // Kann durch eine for-Schleife ersetzt werden.
            //Console.WriteLine(woerter[0]);
            //Console.WriteLine(woerter[1]);
            //Console.WriteLine(woerter[2]);
            //Console.WriteLine(woerter[3]);
            //Console.WriteLine(woerter[4]);

            Console.WriteLine("Alle Wörter:");
            //for ( i = 0; i <= 4; i = i + 1)
            for (i = 0; i < woerter.Length; i++)
            {
                Console.WriteLine(woerter[i]);
            }

            Console.WriteLine("Ein zufälliges Wort:");
            // ich benötige eine zufälligen Index der 0, 1, 2, 3 oder 4 ist.
            index = rnd.Next(0, woerter.Length);// 4 + 1);
            Console.WriteLine("Zufälliger Index: " + index);

            wort = woerter[index];
            wort = wort.ToUpper();
            Console.WriteLine("Zufälliges Wort: \"" + wort + "\"");
            #endregion

            #region Die Buchstaben dieses Wortes zufällig am Bildschirm verteilen.

            // "Bauer"
            char[] buchstaben = wort.ToCharArray();
            /*
             * buchstaben[0] = 'B'
             * buchstaben[1] = 'a'
             * buchstaben[2] = 'u'
             * buchstaben[3] = 'e'
             * buchstaben[4] = 'r'      buchstaben.Length = 5
             *                          Der höchste Index ist aber 4.
             */

            #region Ausgabe des Buchstaben-Arrays
            Console.WriteLine(buchstaben.Length);

            for ( i = 0; i < buchstaben.Length; i = i + 1)
            {
                Console.Write(buchstaben[i]+ " ");
            }
            #endregion

            #region Verteilen aller Buchstaben am Bildschirm.
            // Das Buchstaben-Array durchlaufen und jeden Buchstaben an eine zufällige Position ausgeben.

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetWindowSize(30, 20);
            Console.SetBufferSize(30, 20);
            Console.Title = "Buchstabenverteilung";
            Console.CursorVisible = false;

            Console.Clear();


            for ( i = 0; i < buchstaben.Length; i = i + 1 )
            {
                x = rnd.Next(0, 30);    // 0 bis 29
                y = rnd.Next(0, 20);    // 0 bis 19
                Console.SetCursorPosition(x, y);
                Console.Write(buchstaben[i]);
            }

            #endregion

            #endregion

            Console.ReadKey();
        }
    }
}
