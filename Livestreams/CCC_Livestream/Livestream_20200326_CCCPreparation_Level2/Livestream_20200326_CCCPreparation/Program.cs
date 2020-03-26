using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livestream_20200326_CCCPreparation
{
    class Program
    {
        /*
                                        Input
                                        -4 2
                                        1 3
                                        5
                                        -4 4
                                        0 4
                                        4 3
                                        -1 2
                                        -5 1
                                        Output
                                        4 3 -5 1
             */
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("level2-4.txt");
            StreamWriter writer = new StreamWriter("level2-4.out.txt");

            string line = reader.ReadLine();
            string[] parts = line.Split(' ');
            int x1 = int.Parse(parts[0]);
            int y1 = int.Parse(parts[1]);

            line = reader.ReadLine();
            parts = line.Split(' ');
            int x2 = int.Parse(parts[0]);
            int y2 = int.Parse(parts[1]);

            double alpha1 = Math.Atan2(y1, x1);
            double alpha2 = Math.Atan2(y2, x2);

            // make alpha2 > alpha1

            if ( alpha2 < alpha1 )
            {
                double help = alpha1;
                alpha1 = alpha2;
                alpha2 = help;
            }

            int count = int.Parse(reader.ReadLine());

            while (!reader.EndOfStream)
            {
                // "2 -5"
                line = reader.ReadLine();
                parts = line.Split(' ');
                // "2 -5" -> parts[0] = "2", parts[1] = "-5"
                int x = int.Parse(parts[0]);
                int y = int.Parse(parts[1]);

                double alpha = Math.Atan2(y, x);

                if ( alpha1 < alpha && alpha < alpha2 )
                {
                    // between
                }
                else
                {
                    Console.Write(x + " " + y + " ");
                    writer.Write(x + " " + y + " ");
                }
            }

            reader.Close();
            writer.Close();

            //Console.ReadKey();
        }
    }
}
