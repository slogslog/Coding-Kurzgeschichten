using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roman_möchte_ins_Kino_gehen___Klassen
{
    class Person
    {
        // Instanzvariablen
        // gekapselt durch private
        private readonly string Name;
        private double Geld; // in Euro

        // Konstruktor
        public Person(string name, double geld)
        {
            Name = name;
            Geld = geld;
        }

        // Getter
        public string GetName()
        {
            return Name;
        }

        public double GetGeld()
        {
            return Geld;
        }

        // Methoden (Aktionen)
        public void BekommtGeld(double betrag)
        {
            Console.WriteLine(Name + " bekommt " + betrag + " Euro.");
            Geld = Geld + betrag;
            //Geld += betrag;
            GibtAuskunft();
        }

        public void GibtGeldHer(double betrag)
        {
            Console.WriteLine(Name + " gibt " + betrag + " Euro her.");
            Geld = Geld - betrag;
            //Geld -= betrag;
            GibtAuskunft();
        }

        public void GehtInsKino(double preis)
        {
            Console.WriteLine(Name + " kauft sich eine Karte um " +
                preis + " Euro.");
            GibtGeldHer(preis);
            Console.WriteLine(Name + " schaut sich den Film an.");
        }

        public void GibtAuskunft()
        {
            Console.WriteLine(Name + " hat noch " + Geld + " Euro.");
        }

        public void GibtJemandenGeld(double betrag, Person jemand)
        {
            GibtGeldHer(betrag);
            jemand.BekommtGeld(betrag);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Wieviel Geld soll Roman anfangs haben? ");
            double anfangsbetrag = double.Parse(Console.ReadLine());

            Person kind = new Person("Roman", anfangsbetrag);

            Console.Write("Wieviel Geld soll Romans Mutter anfangs haben? ");
            anfangsbetrag = double.Parse(Console.ReadLine());

            Person mutter = new Person("Mutter", anfangsbetrag);

            Console.WriteLine("Hier beginnt die eigentliche Geschichte...\n");

            const double preisDerKinokarte = 12.5; // in Euro

            if (kind.GetGeld() >= preisDerKinokarte)
            {
                kind.GehtInsKino(preisDerKinokarte);
            }
            else
            {   // Roman hat nicht genug Geld
                double fehlendesGeld = preisDerKinokarte - kind.GetGeld();
                Console.WriteLine(kind.GetName() + " fragt " + mutter.GetName() + " um "
                    + fehlendesGeld + " Euro.");

                if (mutter.GetGeld() >= fehlendesGeld)
                {   // Mutter gibt Roman das fehlende Geld
                    mutter.GibtJemandenGeld(fehlendesGeld, kind);
                    kind.GehtInsKino(preisDerKinokarte);
                }
                else
                {   // Roman kann nicht ins Kino
                    Console.WriteLine(kind.GetName() + " kann nicht ins Kino gehen.");
                    Console.WriteLine(kind.GetName() + " geht mit den Kumpeln Fußballspielen.");
                }
            }

            Console.ReadKey();
        }
    }
}
