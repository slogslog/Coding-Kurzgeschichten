using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HinweiseAufEssbares_ref
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 2 };
            int[] arr2 = new int[] { 3, 4, 5 };

            Console.WriteLine("Vorher: " +String.Join(",", arr1) + "|" +
                  String.Join(",", arr2));

            Swap(ref arr1, ref arr2);

            Console.WriteLine("Nachher: " + String.Join(",", arr1)+"|"+
                              String.Join(",", arr2));
            Console.ReadKey();
        }

        static void Swap(ref int[] a, ref int[] b)
        {
            int[] help = a;
            a = b;
            b = help;
        }
    }
}
