using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeichenZaehlenUndErsetzen
{
    class Program
    {
        static void Main(string[] args)
        {
            string text; //, textNeu;
            char c, cErsetzen;
            //char[] zeichen;
            int i, anzahl;

            anzahl = 0;

            Console.Write("Gib einen Text ein: ");
            text = Console.ReadLine();

            Console.Write("Gib ein einzelnes Zeichen ein: ");
            c = char.Parse(Console.ReadLine());

            //zeichen = text.ToCharArray();

            // Ausgabe des Character Arrays eines Strings
            Console.WriteLine("\nDer ursprüngliche String:");

            for (i = 0; i < text.Length; i = i + 1)
            {
                Console.WriteLine("zeichen[" + i + "] = '" + text[i] + "'");
            }

            // Das Zählen eines Zeichens in einem String
            for (i = 0; i < text.Length; i = i + 1)
            {
                if (text[i] == c)
                {
                    anzahl = anzahl + 1;
                }
            }

            Console.WriteLine("Das Zeichen '{0}' kommt in \"{1}\" {2}mal vor.", c, text, anzahl);
            //Console.WriteLine("Das Zeichen '" + c + "' kommt in \"" + text + "\" " + anzahl + "mal vor.");

            // Das Ersetzen eines Zeichens durch ein anderes

            Console.Write("\nGib das Zeichen ein, das alle '" + c + "'s ersetzen soll: ");
            cErsetzen = char.Parse(Console.ReadLine());

            for (i = 0; i < text.Length; i = i + 1)
            {
                if (text[i] == c)
                {
                    // Zuweisungen auf einzelne Zeichen eines Strings sind in C# und Java nicht möglich!
                    // Der Datentyp ist immutable!
                    // text[i] = cErsetzen;
                    // text = "Donauinsel", c = 'n', cErsetzen = '#'
                    // i = 2     ^
                    // text = "Doauinsel"     Zuerst 'n' entfernen.
                    // text = "Do#auinsel"    Dann '#' einfügen.
                    text = text.Remove(i, 1);
                    text = text.Insert(i, cErsetzen.ToString());
                }
            }

            Console.Write("\nDer neue String: ");
            //textNeu = new string(zeichen);

            Console.Write(text);

            //for (i = 0; i < zeichen.Length; i = i + 1)
            //{
            //    Console.WriteLine("zeichen[" + i + "] = '" + zeichen[i] + "'");
            //}


            Console.ReadKey();
        }
    }
}
