using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min25
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = Quadrat(x);
            Console.WriteLine(y);
            Console.ReadKey();
        }

        static int Quadrat(int q)
        {
            int r = q;
            return r * r;
        }
    }
}
