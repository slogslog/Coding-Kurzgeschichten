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

        public override string ToString()
        {
            string amount = "";

            switch(Volume)
            {
                case Volume._025l: amount = "0,25 l"; break;
                case Volume._033l: amount = "0,33 l"; break;
                case Volume._05l: amount = "0,5 l"; break;

                default:
                    System.Diagnostics.Debug.Assert(false, "Invalid volume!");
                    break;
            }

            return $"{base.ToString()} ({amount})";
        }

        public override decimal GetIngredientsCosts()
        {
            switch(Volume)
            {
                case Volume._05l: return 1.5m;
                case Volume._033l: return 1.2m;
                case Volume._025l: return 0.8m;
            }

            System.Diagnostics.Debug.Assert(false, "Invalid volume!");

            return decimal.MinValue;
        }
    }
}
