using System;

namespace Events_Youtube_Channel
{
    class YoutubeChannel
    {
        public string Name { get; private set; }
        public string Link { get; private set; }

        public YoutubeChannel(string name, string link)
        {
            Name = name;
            Link = link;
        }

        public event EventHandler<NewVideoEventArgs> VideoPublish;

        public void PublishVideo()
        {
            VideoPublish?.Invoke(this, new NewVideoEventArgs(namen[nächstes], DateTime.Now));

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
