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
            return $"{X} {Y} angle={Angle}";
        }

        public double Angle
        {
            get
            {
                double alpha = Math.Atan2(Y, X);
                if (alpha < 0)
                    alpha = 2 * Math.PI + alpha;
                return alpha;
            }
        }
    }

    class PointComparer : IComparer<Point>
    {
        public int Compare(Point a, Point b)
        {
            return a.Angle.CompareTo(b.Angle);
        }
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

    class ObstacleComparer : IComparer<Obstacle>
    {
        public int Compare(Obstacle a, Obstacle b)
        {
            return a.P1.Angle.CompareTo(b.P1.Angle);
        }
    }

    class Program
    {
        /*
                                Input
                                5
                                4
                                0 1 -2
                                -1 1 1
                                0 5 2
                                -3 3 -4
                                Output
                                Any integer between 62 and 67 inclusive.
             */
        static void Main(string[] args)
        {
            string sample = "eg";
            StreamReader reader = new StreamReader($"level5-{sample}.txt");
            StreamWriter writer = new StreamWriter($"level5-{sample}.out.txt");

            string line = reader.ReadLine();
            int s = int.Parse(line);

            List<Point> ptargets = new List<Point>();

            for ( int x = -s; x <= s; x++ )
            {
                for ( int y = -s; y <= s; y++ )
                {
                    ptargets.Add( new Point(x, y) );
                }
            }

            ptargets.Sort(new PointComparer());
            //ptargets.OrderBy(p => p.Angle);

            line = reader.ReadLine();
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

            obstacles.Sort(new ObstacleComparer());

            int countReachable = 0;

            int cursor = 0;

            for ( int i = 0; i < obstacles.Count; i++ )
            {
                Obstacle o = obstacles[i];

                double angle = o.P1.Angle;

                int cursorold = cursor;

                for (; cursor < ptargets.Count; cursor++ )
                {
                    if ( ptargets[cursor].Angle > angle )
                    {
                        break;
                    }
                }

                countReachable += cursor - cursorold;

                angle = o.P2.Angle;

                for (; cursor < ptargets.Count; cursor++)
                {
                    Point t = ptargets[cursor];

                    if (t.Angle > angle)
                    {
                        if (o.P2.Y > 0 && t.Y < o.P2.Y)
                            continue;
                        else if (o.P2.Y < 0 && t.Y > o.P2.Y)
                            continue;

                        break;
                    }
                }

            }

            Console.WriteLine(countReachable);

            reader.Close();
            writer.Close();

            Console.ReadKey();
        }
    }
}
