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

            // user1 soll den Channel abonnieren
            channel.VideoPublish += user1.OnNewVideo;
            Console.WriteLine($"> {user1.Nickname} hat den Channel {channel.Name} abonniert.");

            for (int i = 1; i <= 6; i++)
            {
                Console.WriteLine(i);

                if ( i == 3 )
                {
                    // user2 soll den Channel abonnieren
                    channel.VideoPublish += user2.OnNewVideo;
                    Console.WriteLine($"> {user2.Nickname} hat den Channel {channel.Name} abonniert.");
                }

                if ( i == 5 )
                {
                    // user1 soll den Channel nicht mehr abonnieren
                    channel.VideoPublish -= user1.OnNewVideo;
                    Console.WriteLine($"> {user1.Nickname} hat das Abo beendet.");
                }

                channel.PublishVideo();

                Thread.Sleep(500);
            }

            Console.ReadKey();
        }
    }
}
