using System;
using System.Collections.Generic;

namespace Events_Youtube_Channel
{
    class YoutubeChannel
    {
        public string Name { get; private set; }
        public string Link { get; private set; }

        private List<User> users = new List<User>();

        public YoutubeChannel(string name, string link)
        {
            Name = name;
            Link = link;
        }

        public void Subscribe(User user)
        {
            users.Add(user);
        }

        public void Unsubscribe(User user)
        {
            users.Remove(user);
        }

        public void PublishVideo()
        {
            foreach (User user in users)
            {
                user.OnNewVideo(this, namen[nächstes], DateTime.Now);
            }

            nächstes++;
            if (nächstes == namen.Length)
                nächstes = 0;
        }

        private string[] namen = { "Events", "WPF1", "WPF2", "Recursion", "Nullable Types", "Binary Trees" };
        private int nächstes = 0;

        public override string ToString()
        {
            return Name;
        }
    }
}
