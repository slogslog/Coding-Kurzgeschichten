using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVFernbedienung
{
    class Fernbedienung
    {
        private Fernseher TV;

        public Fernbedienung(Fernseher tv)
        {
            TV = tv;
        }

        public void Benützen()
        {
            FunktionenAnzeigen();

            while (true)
            {
                Fernseher.Funktion f = null;

                char taste = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (taste)
                {
                    case '1': f = TV.Einschalten; break;
                    case '+': f = TV.Lauterdrehen; break;
                    case '-': f = TV.Leiserdrehen; break;
                    case 'n': f = TV.NächsterSender; break;
                    case 'v': f = TV.VorherigerSender; break;
                    case 'x': f = TV.Ausschalten; break;
                    default: continue;
                }

                f?.Invoke();

                Console.WriteLine(TV);
            }
        }

        #region Anzeige der Tasten

        static public Dictionary<char, string> Funktionen = new Dictionary<char, string>()
        {
            { '1', "Einschalten" },
            { '+', "Lauterdrehen" },
            { '-', "Leiserdrehen" },
            { 'n', "NächsterSender" },
            { 'v', "VorherigerSender" },
            { 'x', "Ausschalten" }
        };

        public static void FunktionenAnzeigen()
        {
            foreach (var ZahlUndText in Funktionen)
            {   // ZahlUndText ist vom Typ KeyValuePair<char,string>
                Console.WriteLine(ZahlUndText);
            }
        }

        #endregion
    }
}
