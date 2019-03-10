using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarkt
{
    // Klasse für ein Produkt
    class Produkt
    {
        public string Name { get; private set; }
        public int Stückzahl { get; private set; }

        public Produkt(string name, int stückzahl)
        {
            Name = name;
            Stückzahl = stückzahl;
        }

        public override string ToString()
        {
            return $"{Stückzahl} Stk. {Name}";
        }
    }
}
