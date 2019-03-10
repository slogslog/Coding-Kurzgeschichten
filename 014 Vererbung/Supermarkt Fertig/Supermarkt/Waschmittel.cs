using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarkt
{
    class Waschmittel : Produkt
    {
        public Waschmittel(string name, int stückzahl)
         : base(name, stückzahl)
        {

        }

        public override string ToString()
        {
            return base.ToString() + " (Ist ein Waschmittel)";
        }
    }
}
