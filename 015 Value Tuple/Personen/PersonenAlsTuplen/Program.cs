using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonenAlsTuplen
{
    class Program
    {
        static void Main(string[] args)
        {
            (string name, int größe, double gewicht) person1 = ("Udo", 185, 78.5);
            (string name, int größe, double gewicht) person2 = ("Ruth", 172, 64.2);

            Console.WriteLine(person1.name);
            Console.WriteLine(person2.name);

            Console.ReadKey();
        }
    }
}
