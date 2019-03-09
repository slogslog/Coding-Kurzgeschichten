using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurzgeschichte_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Differenz in Tagen
            DateTime mädchen = new DateTime(2003, 4, 12, 6, 15, 0);
            DateTime oma = new DateTime(1955, 5, 15);

            TimeSpan zeitdauer = mädchen - oma;
            Console.WriteLine(zeitdauer.Days);
            Console.WriteLine(zeitdauer.TotalDays);

            double stunden = (mädchen - oma).TotalHours;
            Console.WriteLine(stunden);

            // 2. Ausgabe von Datumsangaben
            Console.WriteLine(mädchen.ToString("yyyy-MM-dd H:mm:ss"));
            Console.WriteLine(mädchen.ToString("yyyy-MMM-dd H:mm:ss"));
            Console.WriteLine(mädchen.ToString("yyyy-MMMM-dd H:mm:ss"));
            Console.WriteLine($"Die Oma ist an einem " + oma.DayOfWeek + " geboren.");

            // 3. Zeitraum bis jetzt gerade
            Console.WriteLine((DateTime.Now-mädchen).Days);

            //DateTime jetzt = DateTime.Now;
            //for ( int i = 1; i < 100; i++ )
            //{
            //    Console.WriteLine(DateTime.Now.Millisecond);
            //    System.Threading.Thread.Sleep(100);
            //}

            // 4. Parsen
            // Einsturz der Reichsbrücke
            string s = "1976-08-1 5:00";
            DateTime geburtstag = DateTime.Parse(s);
            Console.WriteLine(geburtstag);

            // 5. Rechnen mit Zeitdauern
            // Was ist der 10000. Tag im Leben des Mädchens
            DateTime zehntausenderTag = mädchen.AddDays(10000);
            Console.WriteLine(zehntausenderTag.ToString("yyyy MMMM d"));

            // 6. Schleife von Woche zu Woche über 10 Wochen (=70 Tage)
            DateTime ersteJänner = new DateTime(DateTime.Now.Year, 1, 1);
            for ( DateTime dt = ersteJänner;
                  dt <= ersteJänner.AddDays(10*7);
                  dt = dt.AddDays(7)
                )
            {
                Console.WriteLine(dt.ToString("yyyy-MM-dd"));
            }

            Console.ReadKey();
        }
    }
}
