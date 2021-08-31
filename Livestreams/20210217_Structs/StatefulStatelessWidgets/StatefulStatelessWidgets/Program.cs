using System;

namespace StatefulVsStatelessWidgets
{
    class Program
    {
        static void Main(string[] args)
        {
            Stateless stless = new Stateless();

            Console.WriteLine(stless.GetRandomNumber());


            Stateful stful = new Stateful();
            stful.SetRandomNumber();
            Console.WriteLine(stful.GetNumber());
            stful.SetRandomNumber();
            Console.WriteLine(stful.GetNumber());

            Console.ReadKey();
        }
    }
}
