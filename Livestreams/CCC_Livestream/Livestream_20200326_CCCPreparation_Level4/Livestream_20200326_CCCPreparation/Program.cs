using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livestream_20200326_CCCPreparation
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"{X} {Y}";
        }

        public double Angle => Math.Atan2(Y, X);
        //{
        //    get
        //    {
        //        return Math.Atan2(Y, X);
        //    }
        //}
    }

    class Obstacle
    {
        public Point P1 { get; set; }
        public Point P2 { get; set; }

        public Obstacle(int x1, int x2, int y)
        {
            P1 = new Point(x1, y);
            P2 = new Point(x2, y);

            if( P1.Angle > P2.Angle )
            {
                Point help = P1;
                P1 = P2;
                P2 = help;
            }
        }

        public override string ToString()
        {
            return $"{P1}<->{P2}";
        }
    }

    class Program
    {
        /*
                                Input
                                2
                                -3 5 3
                                1 3 1
                                8
                                -2 5
                                4 4
                                5 4
                                1 2
                                3 2
                                5 2
                                -4 0
                                -1 -3
                                Output
                                1 2 -4 0 -1 -3
             */
        static void Main(string[] args)
        {
            string sample = "4";
            StreamReader reader = new StreamReader($"level4-{sample}.txt");
            StreamWriter writer = new StreamWriter($"level4-{sample}.out.txt");

            string line = reader.ReadLine();
            int counto = int.Parse(line);

            List<Obstacle> obstacles = new List<Obstacle>();

            for (int i = 1; i <= counto; i++)
            {
                line = reader.ReadLine();
                string[] parts = line.Split(' ');
                int x1 = int.Parse(parts[0]);
                int x2 = int.Parse(parts[1]);
                int yo = int.Parse(parts[2]);
                obstacles.Add(new Obstacle(x1, x2, yo));
            }

            //double alpha1 = Math.Atan2(yo, x1);
            //double alpha2 = Math.Atan2(yo, x2);

            // make alpha2 > alpha1

            //if (alpha2 < alpha1)
            //{
            //    double help = alpha1;
            //    alpha1 = alpha2;
            //    alpha2 = help;
            //}

            int count = int.Parse(reader.ReadLine());

            while (!reader.EndOfStream)
            {
                // "2 -5"
                line = reader.ReadLine();
                string[] parts = line.Split(' ');
                // "2 -5" -> parts[0] = "2", parts[1] = "-5"
                int x = int.Parse(parts[0]);
                int y = int.Parse(parts[1]);

                Point target = new Point(x, y);

                bool isReachable = true;

                foreach ( Obstacle obstacle in obstacles )
                {
                    if ( obstacle.P1.Y > 0 && target.Y < obstacle.P1.Y )
                    {

                    }
                    else if ( obstacle.P1.Y < 0 && target.Y > obstacle.P1.Y )
                    {

                    }
                    else if ( obstacle.P1.Angle < target.Angle && target.Angle < obstacle.P2.Angle )
                    {
                        isReachable = false;
                    }
                }

                if ( isReachable )
                {
                    Console.Write(x + " " + y + " ");
                    writer.Write(x + " " + y + " ");
                }

                //if (yo > 0 && y < yo)
                //{
                //    Console.Write(x + " " + y + " ");
                //    writer.Write(x + " " + y + " ");
                //}
                //else if (yo < 0 && y > yo)
                //{
                //    Console.Write(x + " " + y + " ");
                //    writer.Write(x + " " + y + " ");
                //}
                //else if (alpha1 < alpha && alpha < alpha2)
                //{
                //    // between
                //}
                //else
                //{
                //    Console.Write(x + " " + y + " ");
                //    writer.Write(x + " " + y + " ");
                //}
            }

            reader.Close();
            writer.Close();

            // Console.ReadKey();
        }
    }
}
