using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaKebapAndDrinks
{
    enum Volume
    {
        _05l,
        _033l,
        _025l
    }

    class Drink : Product
    {
        public Volume Volume { get; private set; }

        public Drink(string name, decimal purchasePrice, Volume volume)
            : base(name, purchasePrice)
        {
            Volume = volume;
        }
    }
}
