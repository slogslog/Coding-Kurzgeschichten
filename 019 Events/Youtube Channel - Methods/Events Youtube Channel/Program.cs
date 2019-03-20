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

            channel.Subscribe(user1);
            Console.WriteLine($"> {user1.Nickname} hat den Channel {channel.Name} abonniert.");

            for (int i = 1; i <= 6; i++)
            {
                Console.WriteLine(i);

                if ( i == 3 )
                {
                    channel.Subscribe(user2);
                    Console.WriteLine($"> {user2.Nickname} hat den Channel {channel.Name} abonniert.");
                }

                if ( i == 5 )
                {
                    Console.WriteLine($"> {user1.Nickname} hat das Abo beendet.");
                    channel.Unsubscribe(user1);
                }

                channel.PublishVideo();

                Thread.Sleep(500);
            }

            Console.ReadKey();
        }
    }
}
