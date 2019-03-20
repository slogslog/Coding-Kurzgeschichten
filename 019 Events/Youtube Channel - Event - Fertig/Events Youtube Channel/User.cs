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

        // Signatur: EventHandler<NewVideoEventArgs>
        public void OnNewVideo(object sender, NewVideoEventArgs args)
        {
            YoutubeChannel channel = sender as YoutubeChannel;
            Console.WriteLine($"{Nickname}: {channel} hat das Video {args.Video} um {args.Time.ToString("hh:MM:ss")} veröffentlicht.");
        }
    }
}
