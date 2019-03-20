using System;
using System.Collections.Generic;

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

        // TODO: Event definieren

        public void PublishVideo()
        {
            // TODO: alle User verständigen. Folgende Daten sollen geschickt werden:
            // Der Channel, der Videoname und der Zeitpunkt.

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
