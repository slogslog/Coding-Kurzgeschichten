using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livestream_GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, links, rechts;
            n = 80;
            int[] a = new int[n];

            //   |
            //   v
            // 01100101
            //a[18] = 1;
            //a[20] = 1;
            //a[24] = a[27] = 1;

            // Genau in die Mitte der ersten Zeile schreib ich eine 1 rein.
            a[n / 2] = 1;
            //a[n / 2 + 2] = 1;

            #region Ausgabe
            for (i = 0; i < n; i++)
            {
                //if ( a[i] == 1 )
                //{
                //    Console.Write('#');
                //}
                //else
                //{
                //    Console.Write('.');
                //}

                // if-Anweisung in einer Expression
                // conditional operator ?: 
                Console.Write(a[i] == 1 ? '#' : '.');
            }

            Console.WriteLine();
            #endregion

            do
            {
                int[] neu = new int[n];

                for (i = 0; i < n; i = i + 1)
                {
                    links = i - 1;

                    if (links < 0)
                    {
                        links = n - 1;
                    }

                    rechts = i + 1;

                    // Array hat Länge 8.
                    // Dann ist der größte erlaubte Index für []-Zugriff, der Index 7.
                    if (rechts == n)
                    {
                        rechts = 0;
                    }

                    #region 1. Regel
                    // 1. Regel: Jede Zelle mit genau einem lebenden Nachbarn, wechselt ihren Zustand.
                    // Ich habe genau einen lebenden Nachbar, wenn der linke = 1 ist und der rechte = 0
                    // oder wenn der linke = 0 ist und der rechte = 1. (xor)
                    if ((a[links] == 1 && a[rechts] == 0) ||
                        (a[links] == 0 && a[rechts] == 1))
                    {   // Zustand wechseln: 1 -> 0 und 0 -> 1
                        neu[i] = 1 - a[i];

                        //if (a[i] == 1)
                        //{
                        //    neu[i] = 0;
                        //}
                        //else // a[i] == 0
                        //{
                        //    neu[i] = 1;
                        //}
                    }
                    #endregion
                    #region 2. Regel
                    else // Jede Zelle mit keinem oder zwei lebenden Nachbarn, behält ihren Zustand.
                    {
                        neu[i] = a[i];
                    }
                    #endregion
                } // CTRL+K+D: Einrücken (Beautifier)

                // neu ist die nächste Zeile für den nächsten Durchlauf.
                a = neu;

                #region Ausgabe
                // 00011101
                for (i = 0; i < n; i++)
                {
                    if (a[i] == 1)
                    {
                        Console.Write('#');
                    }
                    else
                    {
                        Console.Write('.');
                    }
                }

                Console.WriteLine();
                #endregion



            }   // Ausführen bis ich die Escape-Taste drücke.
            while (Console.ReadKey(true).Key != ConsoleKey.Escape);

            //Console.ReadKey();
        }
    }
}
