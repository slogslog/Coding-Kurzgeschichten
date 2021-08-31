using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatefulVsStatelessWidgets
{
    class Stateful
    {
        private int number;
        private Random rnd;

        public Stateful()
        {
            rnd = new Random();
        }

        public void SetRandomNumber()
        {
            number = rnd.Next(1, 11);
        }

        public int GetNumber()
        {
            return number;
        }
    }
}
