using System;

namespace StatefulVsStatelessWidgets
{
    class Stateless
    {
        public Stateless()
        {
        }

        public int GetRandomNumber()
        {
            return new Random().Next(1,11);
        }
    }
}
