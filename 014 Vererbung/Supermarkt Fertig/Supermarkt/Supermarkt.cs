using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarkt
{
    // Supermarkt Klasse
    class Supermarkt
    {
        #region Daten
        public string Name { get; private set; }
        private List<Produkt> Produkte { get; set; } = new List<Produkt>();
        #endregion

        #region Konstruktoren (ctor)
        public Supermarkt(string name) { Name = name; }
        #endregion

        #region Methoden
        // Fügt ein Produkt hinzu
        public void Hinzufügen(Produkt p)
        {
            Produkte.Add(p);
        }

        public override string ToString()
        {
            return $"{Name}:\n{String.Join("\n", Produkte)}";
        }

        // Gibt alle Produkte zurück, die Lebensmittel sind.
        public List<Lebensmittel> Lebensmittel
        {
            get
            {
                List<Lebensmittel> lebensmittel = new List<Lebensmittel>();

                foreach (Produkt p in Produkte)
                {
                    if ( p is Lebensmittel )
                    {   // Polymorphie
                        lebensmittel.Add(p as Lebensmittel);
                        // lebensmittel.Add((Lebensmittel)p);
                    }
                }

                return lebensmittel;
            }
        }

        public List<Waschmittel> Waschmittel
        {
            get
            {
                List<Waschmittel> lebensmittel = new List<Waschmittel>();

                foreach (Produkt p in Produkte)
                {
                    if (p is Waschmittel wm )
                    {   // Polymorphie
                        lebensmittel.Add(wm);
                    }
                }

                return lebensmittel;
            }
        }
        #endregion
    }
}
