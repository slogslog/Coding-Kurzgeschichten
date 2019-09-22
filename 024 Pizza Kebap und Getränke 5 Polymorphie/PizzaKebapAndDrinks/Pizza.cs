using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaKebapAndDrinks
{
    class Pizza : Product
    {
        public bool IsLarge { get; private set; }

        public Pizza(string name, decimal purchasePrice, bool isLarge)
            : base(name, purchasePrice)
        {
            IsLarge = isLarge;
        }

        public override int GetMinutes()
        {
            return 12;
        }

        public override string ToString()
        {
            string size = IsLarge ? "large" : "small";
            return $"{base.ToString()} ({size})";
        }

        public override decimal GetIngredientsCosts()
        {
            return IsLarge ? 4.5m : 3;
        }
    }
}
