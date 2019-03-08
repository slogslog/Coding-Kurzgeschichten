using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min33
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            Quadrat(ref x);
            Console.WriteLine(x);
            Console.ReadKey();
        }

        static void Quadrat(ref int q)
        {
            q = q * q;
        }
    }
}
