using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collector_Livestream
{
    class Program
    {
        struct Thing
        {
            public int x, y;
            public char c; // '1', '2' oder '3'

            public Thing(int x, int y, char c)
            {
                this.x = x;
                this.y = y;
                this.c = c;
            }
        }

        static void Init(string title, int w, int h, ConsoleColor backgroundColor)
        {
            Console.OutputEncoding = Encoding.Unicode;

            Console.CursorVisible = false;

            Console.Title = title;
            Console.SetWindowSize(w, h);
            Console.SetBufferSize(w, h);

            Console.BackgroundColor = backgroundColor;
            Console.Clear();
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();

            int width = 30;
            int height = 26;
            int x = rnd.Next(0, width - 2); //2;
            int y = rnd.Next(1, height - 2); //3;
            int delay = 150; // ms
            int delaymax = 500; // ms
            int delaymin = 50; // ms
            int delaystep = 50; // ms

            const int NUMBER = 10; // count of objects to be collected by the player

            List<Thing> things = new List<Thing>();

            for ( int i = 1; i <= NUMBER; i++ )
            {
                // Variante 1
                //int number = rnd.Next(1, 4); // 1, 2 oder 3
                //char c = char.Parse(number.ToString());

                // Variante 2
                char c = (char)rnd.Next('1', '4'); // 48, 49 oder 50

                // TODO: add check for duplicate locations of things
                things.Add(new Thing(
                    rnd.Next(0, width - 2),
                    rnd.Next(1, height - 2),
                    c
                    ));
            }

            char player = '\u263A'; // smiley
            int points = 0;

            Stopwatch watch = new Stopwatch();

            Init("Collector", width, height, ConsoleColor.DarkGray);

            foreach (Thing thing in things)
            {
                WriteText(thing.c.ToString(), thing.x, thing.y, ConsoleColor.Cyan);
            }

            WriteText(player.ToString(), x, y, ConsoleColor.Yellow);

            ConsoleKey ck = ConsoleKey.Oem1;    // dummy value
            ConsoleKey ckbackup = ck;

            bool running = true;

            watch.Start();

            // Game loop
            while (running)
            {
                int xprevious = x;
                int yprevious = y;

                if (Console.KeyAvailable)
                {
                    ckbackup = ck;
                    ck = Console.ReadKey(true).Key;
                }

                switch (ck)
                {
                    case ConsoleKey.RightArrow:
                    case ConsoleKey.D:
                        if (x < width - 1)
                        {
                            x++;
                        }
                        break;

                    case ConsoleKey.LeftArrow:
                    case ConsoleKey.A:
                        if (x > 0)
                        {
                            x--; // x = x - 1;
                        }
                        break;

                    case ConsoleKey.DownArrow:
                    case ConsoleKey.S:
                        if (y < height - 1)
                            y++;

                        break;

                    case ConsoleKey.UpArrow:
                    case ConsoleKey.W:
                        if (y > 1)
                            y--;

                        break;

                    case ConsoleKey.PageUp:
                        if (delay > delaymin)
                        {
                            //delay = delay - delaystep;
                            delay -= delaystep;
                        }

                        ck = ckbackup;

                        continue;

                    case ConsoleKey.PageDown:
                        if (delay < delaymax)
                        {
                            delay += delaystep;
                        }

                        ck = ckbackup;

                        continue;

                    case ConsoleKey.Escape:
                        running = false;
                        continue;
                }

                if (xprevious != x || yprevious != y)
                {   // player entered a new location
                    Console.SetCursorPosition(xprevious, yprevious);
                    Console.Write(' ');

                    WriteText(player.ToString(), x, y, ConsoleColor.Yellow);

                    // check whether a thing was collected
                    for ( int i = things.Count-1; i >= 0; i-- )
                    {
                        Thing thing = things[i];

                        if ( x == thing.x && y == thing.y )
                        {
                            // Variante 1
                            points += int.Parse(thing.c.ToString());

                            // Variante 2
                            //points = thing.c - '0';

                            // remove thing from the list of things
                            things.RemoveAt(i);
                        }
                    }

                    WriteText($"{points.ToString()} points ({things.Count})", width / 2, 0, ConsoleColor.White);

                    if ( things.Count == 0 )
                    {
                        running = false;
                        continue;
                    }
                }

                System.Threading.Thread.Sleep(delay);

                double time = Math.Round(watch.ElapsedMilliseconds / 1000d, 1);

                WriteText($"{time.ToString("F1"),4} s", 0, 0, ConsoleColor.White);
            } // End of game loop

            watch.Stop();

            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.WriteLine("Game over!");
            Console.WriteLine($"You've collected {points} points.");
            Console.WriteLine($"Your time {Math.Round(watch.ElapsedMilliseconds / 1000d, 1)} seconds.");

            Console.ReadKey();
        }

        static void WriteText(string text, int x, int y, ConsoleColor color)
        {
            ConsoleColor backup = Console.ForegroundColor;
            Console.ForegroundColor = color;

            Console.SetCursorPosition(x, y);
            Console.Write(text);

            Console.ForegroundColor = backup;
        }
    }
}
