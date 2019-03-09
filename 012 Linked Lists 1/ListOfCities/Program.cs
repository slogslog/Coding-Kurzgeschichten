using System;

namespace ListOfCities
{
    class Program
    {
        static void Main(string[] args)
        {
            City hamburg = new City("Hamburg", 53.5506, 9.9933);
            City london = new City("London", 51.5094, -0.1183);
            City paris = new City("Paris", 48.8567, 2.3517);
            City vienna = new City("Vienna", 48.2083, 16.3731);
            City roma = new City("Roma", 41.8833, 12.4833);
            City istanbul = new City("Istanbul", 41.01, 28.9603);

            Node nodeVienna = new Node(vienna);
            Node nodeParis = new Node(paris);
            Node nodeLondon = new Node(london);
            Node nodeHamburg = new Node(hamburg);

            nodeVienna.Next = nodeParis;
            nodeParis.Next = nodeLondon;
            nodeLondon.Next = nodeHamburg;

            List route = new List(nodeVienna);
            // Änderung der Route
            nodeVienna.Next = nodeLondon;

            Console.ReadKey();
        }
    }
}
