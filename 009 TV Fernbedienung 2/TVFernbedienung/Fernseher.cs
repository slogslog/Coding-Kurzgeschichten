using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVFernbedienung
{
    class Fernseher
    {
        List<string> senderListe = new List<string>()
        {
            "ORF1", "ZDF", "CNN"
        };

        private int aktuellerSender = 0;
        private bool IstEingeschalten;

        private int Lautstärke = 0;
        const int maxLautstärke = 10;

        public Fernseher()
        {
            IstEingeschalten = false;
        }

        public void Einschalten()
        {
            IstEingeschalten = true;
        }

        public void Ausschalten()
        {
            IstEingeschalten = false;
        }

        public void Lauterdrehen()
        {
            if (Lautstärke < maxLautstärke)
            {
                Lautstärke++;
            }
            // else Lautstärke ist schon maximal
        }

        public void Leiserdrehen()
        {
            if (Lautstärke > 0)
            {
                Lautstärke--;
            }
            // else Lautstärke ist schon 0
        }

        public void NächsterSender()
        {
            aktuellerSender++;

            if (aktuellerSender == senderListe.Count)
            {   // Vom letzten Sender zum ersten Sender schalten.
                aktuellerSender = 0;
            }
        }

        public void VorherigerSender()
        {
            aktuellerSender--;

            if (aktuellerSender < 0)
            {   // Vom ersten Sender zum letzten Sender schalten.
                aktuellerSender = senderListe.Count - 1;
            }
        }

        public override string ToString()
        {
            if (IstEingeschalten)
            {
                return $"Es läuft {senderListe[aktuellerSender]} mit Lautstärke {Lautstärke}.";
            }

            // ist ausgeschalten
            return "OFF";
        }
    }
}
