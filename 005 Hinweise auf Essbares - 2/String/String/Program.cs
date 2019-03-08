using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            s = "Info";

            string t = s;
            t = t + "rmatik";
            s = "ist cool!";
            Console.WriteLine(t + " " + s);
            Console.ReadKey();
        }
    }
}
