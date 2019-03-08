using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roman_möchte_ins_Kino_und_braucht_Knete_mit_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            double preisDerKinoKarte = 12.5; // in Euro

            Person roman = new Person();
            roman.Name = "Roman";

            Console.Write("Wieviel Geld soll Roman anfangs besitzen? ");
            roman.Geld = double.Parse(Console.ReadLine());

            Person mutter = new Person();
            mutter.Name = "Mutter";

            Console.Write("Wieviel Geld soll Romans Mutter anfangs besitzen? ");
            mutter.Geld = double.Parse(Console.ReadLine());

            roman.Ausgeben();
            mutter.Ausgeben();

            Console.WriteLine("Die Geschichte beginnt...\n");

            if (roman.Geld >= preisDerKinoKarte)
            {
                roman.Kinobesuch(preisDerKinoKarte);
            }
            else
            {
                double fehlendesGeld = preisDerKinoKarte - roman.Geld;
                Console.WriteLine(roman.Name + " fragt seine " + mutter.Name);
                Console.WriteLine("Es fehlen " + fehlendesGeld + " Euro.");

                if (mutter.Geld >= fehlendesGeld)
                {
                    mutter.GibtGeldHer(fehlendesGeld);
                    roman.BekommtGeld(fehlendesGeld);
                    roman.Kinobesuch(preisDerKinoKarte);
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
