using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_Youtube_Channel
{
    class User
    {
        public string Nickname { get; private set; }

        public User(string nickname)
        {
            Nickname = nickname;
        }

        public void OnNewVideo(YoutubeChannel channel, string name, DateTime time)
        {
            Console.WriteLine($"{Nickname}: {channel} hat das Video {name} um {time.ToString("hh:MM:ss")} veröffentlicht.");
        }
    }
}
