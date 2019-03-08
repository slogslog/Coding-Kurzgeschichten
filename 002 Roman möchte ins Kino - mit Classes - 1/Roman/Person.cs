using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roman_möchte_ins_Kino_und_braucht_Knete_mit_Classes
{
    class Person
    {
        public string Name;
        public double Geld; // in Euro

        public void BekommtGeld(double geld)
        {
            Console.WriteLine(Name + " bekommt " + geld + " Euro.");
            //Geld = Geld + geld;
            Geld += geld;
            Ausgeben();
        }

        public void GibtGeldHer(double geld)
        {
            Console.WriteLine(Name + " gibt " + geld + " Euro her.");
            //Geld = Geld - geld;
            Geld -= geld;
            Ausgeben();
        }

        public void Kinobesuch(double preis)
        {
            Console.WriteLine(Name + " kauft sich eine Kinokarte um " + preis + " Euro.");
            GibtGeldHer(preis);
            Console.WriteLine(Name + " schaut sich den Film an.");
        }

        public void Ausgeben()
        {
            Console.WriteLine(Name + " besitzt noch " + Geld);
        }
    }
}
