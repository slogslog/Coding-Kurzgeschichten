using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfCities
{
    class List
    {
        private class Node
        {
            // Data
            public City City { get; private set; }
            public Node Next { get; set; }

            // ctor
            public Node(City city) { City = city; }

            public override string ToString() { return City.Name; }
        }

        // Data
        private Node Head { get; set; }

        // ctor
        public List() { }

        public void Add(City city)
        {
            if (Head == null)
            {   // Die Liste ist noch leer.
                Head = new Node(city);
                return;
            }

            // Sucht die letzte Node der Liste.
            Node i = Head;
            for (; i.Next != null; i = i.Next)
            {
            }

            i.Next = new Node(city);
        }

        public override string ToString()
        {
            string s = "";

            Node i = Head;
            for ( ; i.Next != null ; i = i.Next )
            {
                s += i.City.Name + " ";
            }

            s += i.City.Name;

            return s;
        }
    }
}
