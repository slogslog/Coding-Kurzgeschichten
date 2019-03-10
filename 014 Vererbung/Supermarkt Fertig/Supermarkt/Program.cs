using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarkt
{
    class Program
    {
        static void Main(string[] args)
        {
            // Anlegen des Supermarkts
            Supermarkt sm = new Supermarkt("KaufHierAberZackig");

            // Befüllen des Supermarkts
            sm.Hinzufügen(new Lebensmittel("Ovomaltine 100 g", 2));
            sm.Hinzufügen(new Lebensmittel("Teekanne Lillifee 10 Sackerl", 2));
            sm.Hinzufügen(new Lebensmittel("Teekanne Ostfriesentee 10 Sackerl", 1));
            sm.Hinzufügen(new Lebensmittel("Melitta Harmonie mile 250 g", 1));
            sm.Hinzufügen(new Hygieneartikel("Tempo 100 Stk", 2));
            sm.Hinzufügen(new Waschmittel("Weißer Riese XL", 1));
            sm.Hinzufügen(new Waschmittel("Lenor 5 kg", 1));
            sm.Hinzufügen(new Waschmittel("Ariel 5 kg", 2));
            sm.Hinzufügen(new Lebensmittel("Jodsalz 500 g", 2));
            sm.Hinzufügen(new Lebensmittel("Zwieback Kokos 225 g", 2));
            sm.Hinzufügen(new Lebensmittel("Dr. Oetker Grießbrei", 3));
            sm.Hinzufügen(new Lebensmittel("Dr. Oetker Bistro Baguette Salami", 1));
            sm.Hinzufügen(new Lebensmittel("Iglo Fischstäbchen 15 Stk", 1));
            sm.Hinzufügen(new Lebensmittel("Super Dickmanns", 1));
            sm.Hinzufügen(new Lebensmittel("Brandt Minis Vollmilch Schoko", 1));
            sm.Hinzufügen(new Lebensmittel("Magnum Classic 4 Stk", 1));
            sm.Hinzufügen(new Lebensmittel("Müller's & Mühle Basmati Reis 500g", 1));
            sm.Hinzufügen(new Lebensmittel("Fritt", 2));
            sm.Hinzufügen(new Lebensmittel("Maultaschen 360g", 2)); // Schwäbische Spezialität
            sm.Hinzufügen(new Tierfutter("bunny Kaninchen Traum", 2)); // Kaninchenfutter
            sm.Hinzufügen(new Lebensmittel("Dr. Oetker Extra Gelierzucker 500g", 1));
            sm.Hinzufügen(new Lebensmittel("Oro di Parma Sugo", 2));
            
            // Ausgabe aller Lebensmittel (=alles was Menschen essen)
            Console.WriteLine(String.Join("\n", sm.Lebensmittel));
            Console.WriteLine();
            Console.WriteLine(String.Join("\n", sm.Waschmittel));

            Console.ReadKey();
        }
    }
}
