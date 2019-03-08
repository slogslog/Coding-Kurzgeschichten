using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinUndMaxVonWerten
{
    class Program
    {
        // Berechnet das Minimum und Maximum von array und liefert sie in 
        // den Outputparameter min und max zurück.
        static (int minimum, int maximum) FindeMinUndMax(int[] array)
        {
            // Die allererste Zahl ist einmal die kleinste und größte Zahl.
            int min = array[0];
            int max = array[0];

            // Überprüfe, ob alle weiteren Zahlen des Arrays größer oder kleiner sind.
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                    min = array[i]; // array[i] ist kleiner -> in min merken

                if (array[i] > max) // array[i] ist größer -> in max merken
                    max = array[i];
            }

            // min speichert jetzt die kleinste Zahl, max die größte
            // Definieren ein Tuple.
            // Tuple ist ungefähr eine Struct.
            return (min, max);
        }

        static void Main(string[] args)
        {
            int[] zahlen = { 4, 6, 10, 2, -8, 12, -2 };

            // var ist ein Faulheitsschlüsselwort: var sagt dem Compiler, 
            // dass er den Typ selbst bestimmen soll.
            var tuple = FindeMinUndMax(zahlen);

            Console.WriteLine("Die kleinste Zahl ist " + tuple.minimum + ".");
            Console.WriteLine("Die größte Zahl ist " + tuple.maximum + ".");

            Console.ReadKey();
        }
    }
}
