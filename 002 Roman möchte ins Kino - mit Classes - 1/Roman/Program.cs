using System;

namespace Roman_möchte_ins_Kino_und_braucht_Knete_mit_Classes
{
    class Person
    {
        // Instanzvariablen
        public string Name;
        public double Geld; // in Euro

        // Methoden (Aktionen)
        public void BekommtGeld(double geld)
        {
            Console.WriteLine(Name + " bekommt " + geld + " Euro.");
            Geld = Geld + geld;
            // Geld += geld;
            GibtAuskunft();
        }

        public void GibtGeldHer(double geld)
        {
            Console.WriteLine(Name + " gibt " + geld + " Euro her.");
            Geld = Geld - geld;
            // Geld -= geld;
            GibtAuskunft();
        }

        public void GehtInsKino(double preis)
        {
            Console.WriteLine(Name + " kauft sich eine Kinokarte um " + preis + " Euro.");
            GibtGeldHer(preis);
            Console.WriteLine(Name + " schaut sich den Film an.");
        }

        public void GibtAuskunft()
        {
            Console.WriteLine(Name + " hat noch " + Geld + " Euro.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Wieviel Geld soll Roman anfangs besitzen? ");
            double anfangsbetrag = double.Parse(Console.ReadLine());

            Person kind = new Person();
            kind.Name = "Roman";
            kind.Geld = anfangsbetrag;

            Console.Write("Wieviel Geld soll Romans Mutter anfangs besitzen? ");
            anfangsbetrag = double.Parse(Console.ReadLine());

            Person mutter = new Person();
            mutter.Name = "Mutter";
            mutter.Geld = anfangsbetrag;

            kind.GibtAuskunft();
            mutter.GibtAuskunft();

            Console.WriteLine("Hier beginnt die eigentliche Geschichte...\n");

            const double preisDerKinoKarte = 12.5; // in Euro

            if (kind.Geld >= preisDerKinoKarte)
            {
                kind.GehtInsKino(preisDerKinoKarte);
            }
            else
            {
                double fehlendesGeld = preisDerKinoKarte - kind.Geld;
                Console.WriteLine(kind.Name + " fragt " + mutter.Name + " um " + fehlendesGeld + " Euro.");

                if (mutter.Geld >= fehlendesGeld)
                {   // Mutter gibt Roman das fehlende Geld
                    mutter.GibtGeldHer(fehlendesGeld);
                    kind.BekommtGeld(fehlendesGeld);
                    kind.GehtInsKino(preisDerKinoKarte);
                }
                else
                {   // Roman kann nicht ins Kino
                    Console.WriteLine(kind.Name + " kann nicht ins Kino gehen.");
                    Console.WriteLine(kind.Name + " geht mit den Kumpeln Fußballspielen.");
                }
            }

            Console.ReadKey();
        }
    }

}
