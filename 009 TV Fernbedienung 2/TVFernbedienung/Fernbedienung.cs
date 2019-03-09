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

            Funktionen['1'] = TV.Einschalten;
            Funktionen['+'] = TV.Lauterdrehen;
            Funktionen['-'] = TV.Leiserdrehen;
            Funktionen['n'] = TV.NächsterSender;
            Funktionen['v'] = TV.VorherigerSender;
            Funktionen['x'] = TV.Ausschalten;
        }

        public void Benützen()
        {
            FunktionenAnzeigen();

            while (true)
            {
                char taste = Console.ReadKey().KeyChar;
                Console.WriteLine();

                if ( !Funktionen.ContainsKey(taste) )
                {
                    continue;
                }

                Action f = Funktionen[taste];

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

        static public Dictionary<char, Action> Funktionen = new Dictionary<char, Action>();

        public static void FunktionenAnzeigen()
        {
            foreach (var ZahlUndFunktion in Funktionen)
            {   // ZahlUndText ist vom Typ KeyValuePair<char,string>
                Console.WriteLine($"{ZahlUndFunktion.Key}: {ZahlUndFunktion.Value.Method.Name}");
            }
        }

        #endregion
    }
}
