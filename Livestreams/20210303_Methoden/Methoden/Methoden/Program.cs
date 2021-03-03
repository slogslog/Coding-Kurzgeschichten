using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methoden
{
    class Program
    {
        // Methode, Function, Procedure
        // color ist ein Inputparameter
        static void CopyrightMeldungAusgeben(ConsoleColor color, double sekunden)
        {
            Console.ForegroundColor = color;
            Console.WriteLine("\u00A9Coding Kurzgeschichten, Wien 2021"); // U+00A9 ist das Copyrightzeichen
            Console.WriteLine("Datum und Uhrzeit: " + DateTime.Now);
            Console.Beep(frequency: 277 /* in Hz (277 ist die Note C#) ;-) */, 
                duration: (int)(sekunden * 1000));
            Console.ResetColor();
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            // Willkommensmeldung
            Console.WriteLine("HALLÖCHEN!");
            // Den oberen Codeblock aufrufen
            // Hier soll die Ausgabe in Gelb passieren!
            // named parameters, variable:
            CopyrightMeldungAusgeben(sekunden: 0.5, color: ConsoleColor.Yellow);

            // Eingabe und Berechnung
            Console.Write("Gib deine Körpergröße in Zentimeter ein: ");
            int cm = int.Parse(Console.ReadLine());
            double feet = Math.Round(cm * 3.28084e-2, 2); // gerundet auf zwei Stellen
            Console.WriteLine("Du bist " + feet + " Fuß groß.");

            // Verabschiedung
            // Den oberen Codeblock aufrufen
            // Hier soll die Ausgabe in Rot passieren.
            // unnamed parameters
            CopyrightMeldungAusgeben(ConsoleColor.Red, 0.2);
            Console.WriteLine("AUF WIEDERSEHEN!");
            Console.ReadKey();
        }
    }
}
