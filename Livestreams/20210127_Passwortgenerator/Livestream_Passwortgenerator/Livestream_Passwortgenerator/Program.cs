using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livestream_Passwortgenerator
{
    class Program
    {
        /* Erzeugt n-viele Passwörter mit einer bestimmten Länge l 
         * passwords <n> <l>
         * 
         * Example:
         *      C:\>passwords 3 8
         *      ghH,*4a8
         *      U%30aMkL
         *      7_qR9R09
         */

        // passwords     3       8
        //            args[0] args[1]
        //              "3"     "8"
        static void Main(string[] args)
        {
            // Console.WriteLine(args.Length);
            if ( args.Length != 2 )
            {
                Console.WriteLine("Usage: passwords <n> <l>\nn ... Anzahl der Passwörter\nl ... Länge der Passwörter");
                // Fehlercode > 0 zurück
                Environment.Exit(1);
            }

            Random rnd = new Random();

            int i, j, hoechsterIndex;
            const string alleZeichen = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789,.-;:_!\"$%&/()=?*'+#";

            // string besteht aus lauter chars (=Text besteht aus einzelnen Zeichen)
            char[] zeichenArray = alleZeichen.ToCharArray();
            hoechsterIndex = zeichenArray.Length - 1;
            //Console.WriteLine(zeichenArray[hoechsterIndex]);

            // 1. Eine Schleife für die gewünschte Anzahl der Zeichen
            // 2. Man hängt dann ein zufälliges Zeichen nach dem anderen an einen Ergebnisstring an.
            //    Bestimm einen zufälligen Index in das Zeichenarray (zeichenArray) und hänge dieses Zeichen
            //    an den Ergebnisstring an.

            #region Testen
            //for ( i = 0; i < args.Length; i = i + 1)
            //{
            //    Console.WriteLine($"args[{i}] = {args[i]}");
            //}

            // Die Anzahl soll nicht vom Benutzer eingegeben werden, sondern von der 
            // Commandline übernommen werden.
            //Console.Write("Gib eine Anzahl ein: ");
            //int anzahl = int.Parse(Console.ReadLine());
            #endregion

            // Umbenennen von Variablen geht in Visual Studio: CTRL + R + R
            int n = int.Parse(args[0]); // Anzahl der Passwörter
            int l = int.Parse(args[1]); // Länge der Passwörter

            for (j = 0; j < n; j = j + 1)
            {
                // Erzeuge ein Passwort
                string password = String.Empty; // entspricht ""

                // 1.
                for (i = 0; i < l; i = i + 1)
                {
                    // 2. Zufälliges Zeichen bestimmen: zufälligen Index
                    int zufaelligeIndex = rnd.Next(zeichenArray.Length);
                    char c = zeichenArray[zufaelligeIndex];
                    password = password + c;

                    //Console.WriteLine(rnd.Next(1,11));  // von 1 bis 10
                }

                Console.WriteLine(password);
            }
            // Formatieren des gesamten Codes durch CTRL + K + D
        }
    }
}
