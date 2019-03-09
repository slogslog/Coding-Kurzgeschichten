using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfCities
{
    class List
    {
        // Data
        private Node Head { get; set; }

        // ctor
        public List()
        {
        }

        public List(Node first)
        {
            Head = first;
        }
    }
}






/*






        public void Remove(string cityname)
        {
            if ( Head.City.Name == cityname )
            {
                Head = Head.Next;
                return;
            }

            for (Node i = Head; i.Next != null; i = i.Next)
            {
                if ( i.Next.City.Name == cityname )
                {
                    i.Next = i.Next.Next;
                    return;
                }
            }
        }

*/
