using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVFernbedienung
{
    class Program
    {
        static void Main(string[] args)
        {
            Fernseher tv = new Fernseher();
            Fernbedienung fb = new Fernbedienung(tv);
            fb.Benützen();
        }
    }
}
