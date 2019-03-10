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
            sm.Hinzufügen(new Produkt("Ovomaltine 100 g", 2));
            sm.Hinzufügen(new Produkt("Teekanne Lillifee 10 Sackerl", 2));
            sm.Hinzufügen(new Produkt("Teekanne Ostfriesentee 10 Sackerl", 1));
            sm.Hinzufügen(new Produkt("Melitta Harmonie mile 250 g", 1));
            sm.Hinzufügen(new Produkt("Tempo 100 Stk", 2));
            sm.Hinzufügen(new Produkt("Weißer Riese XL", 1));
            sm.Hinzufügen(new Produkt("Lenor 5 kg", 1));
            sm.Hinzufügen(new Produkt("Ariel 5 kg", 2));
            sm.Hinzufügen(new Produkt("Jodsalz 500 g", 2));
            sm.Hinzufügen(new Produkt("Zwieback Kokos 225 g", 2));
            sm.Hinzufügen(new Produkt("Dr. Oetker Grießbrei", 3));
            sm.Hinzufügen(new Produkt("Dr. Oetker Bistro Baguette Salami", 1));
            sm.Hinzufügen(new Produkt("Iglo Fischstäbchen 15 Stk", 1));
            sm.Hinzufügen(new Produkt("Super Dickmanns", 1));
            sm.Hinzufügen(new Produkt("Brandt Minis Vollmilch Schoko", 1));
            sm.Hinzufügen(new Produkt("Magnum Classic 4 Stk", 1));
            sm.Hinzufügen(new Produkt("Müller's & Mühle Basmati Reis 500g", 1));
            sm.Hinzufügen(new Produkt("Fritt", 2));
            sm.Hinzufügen(new Produkt("Maultaschen 360g", 2)); // Schwäbische Spezialität
            sm.Hinzufügen(new Produkt("bunny Kaninchen Traum", 2)); // Kaninchenfutter
            sm.Hinzufügen(new Produkt("Dr. Oetker Extra Gelierzucker 500g", 1));
            sm.Hinzufügen(new Produkt("Oro di Parma Sugo", 2));
            
            // TODO: Ausgabe aller Produkt (=alles was Menschen essen)

            Console.ReadKey();
        }
    }
}
