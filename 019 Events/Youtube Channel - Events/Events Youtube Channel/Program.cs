using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Events_Youtube_Channel
{
    class Program
    {
        static void Main(string[] args)
        {
            var channel = new YoutubeChannel("Kurzgeschichten in C#",
                                             "https://www.youtube.com/channel/UCMcHR9DBcGsbDtoZyZIFqoA");

            var user1 = new User("Codefuzzi");
            var user2 = new User("Codefazzi");

            // TODO: user1 soll den Channel abonnieren
            Console.WriteLine($"> {user1.Nickname} hat den Channel {channel.Name} abonniert.");

            for (int i = 1; i <= 6; i++)
            {
                Console.WriteLine(i);

                if ( i == 3 )
                {
                    // TODO: user2 soll den Channel abonnieren
                    Console.WriteLine($"> {user2.Nickname} hat den Channel {channel.Name} abonniert.");
                }

                if ( i == 5 )
                {
                    // TODO: user1 soll den Channel abonnieren
                    Console.WriteLine($"> {user1.Nickname} hat das Abo beendet.");
                }

                channel.PublishVideo();

                Thread.Sleep(500);
            }

            Console.ReadKey();
        }
    }
}
