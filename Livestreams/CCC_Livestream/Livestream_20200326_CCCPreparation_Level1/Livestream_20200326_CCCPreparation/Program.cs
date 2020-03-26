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
                    3
                    7
                    2 -5
                    2 4
                    0 4
                    -2 5
                    -1 2
                    -2 2
                    -5 4
                    Output
                    2 -5 -1 2 -2 2
             */
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("level1-4.txt");
            StreamWriter writer = new StreamWriter("level1-4.out.txt");

            string line = reader.ReadLine();
            int ysep = int.Parse(line); // 3

            int count = int.Parse(reader.ReadLine());

            while (!reader.EndOfStream)
            {
                // "2 -5"
                line = reader.ReadLine();
                string[] parts = line.Split(' ');
                // "2 -5" -> parts[0] = "2", parts[1] = "-5"
                int x = int.Parse(parts[0]);
                int y = int.Parse(parts[1]);

                // x = 2, y = -5
                if (ysep > 0)
                {
                    if (y < ysep)
                    {
                        Console.Write(x + " " + y + " ");
                        writer.Write(x + " " + y + " ");
                    }
                }
                else
                {   // ysep < 0
                    if ( y > ysep )
                    {
                        Console.Write(x + " " + y + " ");
                        writer.Write(x + " " + y + " ");
                    }
                }
            }

            reader.Close();
            writer.Close();

            //Console.ReadKey();
        }
    }
}
