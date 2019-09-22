using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaKebapAndDrinks
{
    class Product
    {
        public string Name { get; private set; }
        public decimal PurchasePrice { get; private set; }

        public Product(string name, decimal purchasePrice)
        {
            Name = name;
            PurchasePrice = purchasePrice;
        }

        public override string ToString()
        {
            return $"{Name} {PurchasePrice:C2}";
        }
    }
}
