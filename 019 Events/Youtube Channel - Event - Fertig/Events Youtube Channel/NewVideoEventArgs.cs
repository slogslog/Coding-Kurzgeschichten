using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_Youtube_Channel
{
    class NewVideoEventArgs : EventArgs
    {
        public string Video { get; }  // Name des veröffentlichten Videos
        public DateTime Time { get; } // Zeitpunkt der Veröffentlichung

        public NewVideoEventArgs(string video, DateTime time)
        {
            Video = video;
            Time = time;
        }
    }
}
