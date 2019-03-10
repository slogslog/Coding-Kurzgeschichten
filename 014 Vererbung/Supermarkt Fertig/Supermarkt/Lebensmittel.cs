using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarkt
{
    // Alle Produkte die Menschen essen können
    // Lebensmittel wird von der Basisklasse Produkt abgeleitet.
    // Lebensmittel ist eine abgeleitete Klasse.
    class Lebensmittel : Produkt
    {
        public Lebensmittel(string name, int stückzahl)
            : base(name,stückzahl)
        {

        }

        public override string ToString()
        {
            return base.ToString() + " (Ist ein Lebensmittel)";
        }
    }
}
