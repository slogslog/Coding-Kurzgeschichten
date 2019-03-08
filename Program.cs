using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roman_möchte_ins_Kino_und_braucht_Knete_mit_Structs
{
    struct Person
    {
        public string Name;
        public double Geld; // in Euro
    }

    class Program
    {
        static void Ausgeben(Person p)
        {
            Console.WriteLine(p.Name + " besitzt noch " + p.Geld);
        }

        static void BekommtGeld( ref Person p, double geld )
        {
            Console.WriteLine(p.Name + " bekommt " + geld + " Euro.");
            p.Geld = p.Geld + geld;
            //p.Geld += geld;
            Ausgeben(p);
        }

        static void GibtGeldHer(ref Person p, double geld)
        {
            Console.WriteLine(p.Name + " gibt " + geld + " Euro her.");
            p.Geld = p.Geld - geld;
            Ausgeben(p);
        }

        static void Kinobesuch(ref Person p, double preis)
        {
            Console.WriteLine(p.Name + " kauft sich eine Kinokarte um " + preis + " Euro.");
            GibtGeldHer(ref p, preis);
            Console.WriteLine(p.Name + " schaut sich den Film an.");
        }

        static void Main(string[] args)
        {
            double preisDerKinoKarte = 12.5; // in Euro

            Person roman;
            roman.Name = "Roman";

            Console.Write("Wieviel Geld soll Roman anfangs besitzen? ");
            roman.Geld = double.Parse(Console.ReadLine());

            Person mutter = new Person { Name = "Mutter" };

            Console.Write("Wieviel Geld soll Romans Mutter anfangs besitzen? ");
            mutter.Geld = double.Parse(Console.ReadLine());

            Ausgeben(roman);
            Ausgeben(mutter);
            Console.WriteLine("Die Geschichte beginnt...\n");

            if ( roman.Geld >= preisDerKinoKarte )
            {
                Kinobesuch(ref roman, preisDerKinoKarte);
            }
            else
            {
                double fehlendesGeld = preisDerKinoKarte - roman.Geld;
                Console.WriteLine(roman.Name + " fragt seine " + mutter.Name);
                Console.WriteLine("Es fehlen " + fehlendesGeld + " Euro.");

                if ( mutter.Geld >= fehlendesGeld )
                {
                    GibtGeldHer(ref mutter, fehlendesGeld);
                    BekommtGeld(ref roman, fehlendesGeld);
                    Kinobesuch(ref roman, preisDerKinoKarte);
                }
                else
                {
                    Console.WriteLine(mutter.Name + " hat zuwenig Geld.");
                    Console.WriteLine(roman.Name + " kann nicht ins Kino gehen und geht mit Kumpeln Fußballspielen.");
                }
            }

            Console.ReadKey();
        }
    }
}
