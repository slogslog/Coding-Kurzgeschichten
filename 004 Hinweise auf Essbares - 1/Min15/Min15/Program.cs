using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min15
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            x = 5;

            int q = x;
            q = q * q;

            Console.WriteLine($"{x}² = {q}");
            Console.ReadKey();
        }
    }
}
