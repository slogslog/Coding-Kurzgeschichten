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
        public List<Produkt> Lebensmittel
        {
            get
            {
                List<Produkt> lebensmittel = new List<Produkt>();

                foreach (Produkt p in Produkte)
                {
                    // TODO: Ergänzen
                }

                return lebensmittel;
            }
        }
        #endregion
    }
}
