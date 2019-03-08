using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min21
{
    class Program
    {
        static void Main(string[] args)
        {
            int c;
            c = 'A';

            // next it das nachfolgende Zeichen 'B'
            char next = (char)(c + 1);

            Console.WriteLine($"{c}+1 -> {next}");
            Console.ReadKey();
        }
    }
}
