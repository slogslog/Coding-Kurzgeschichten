using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace School_CCC_20170331
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(@"..\..\..\CCC data\level1-eg.txt");

            string line = reader.ReadLine();
            int y = int.Parse(line);

            line = reader.ReadLine();
            int n = int.Parse(line);

            // Value Tuples
            (int x, int y)[] targets = new (int x, int y)[n];

            int i = 0;

            while(!reader.EndOfStream)
            {
                line = reader.ReadLine();

                // e. g. "2 -5"
                // => (x,y)

                string[] parts = line.Split(' ');
                // parts[0] = "2"
                // parts[1] = "-5"

                int _x = int.Parse(parts[0]);
                int _y = int.Parse(parts[1]);

                targets[i] = (_x, _y);
                i++;
            }

            reader.Close();

            for ( i = 0; i < n; i++ )
            {
                if ( targets[i].y < y )
                {
                    Console.Write($"{targets[i].x} {targets[i].y} ");
                }
            }

            Console.ReadKey();
        }
    }
}
