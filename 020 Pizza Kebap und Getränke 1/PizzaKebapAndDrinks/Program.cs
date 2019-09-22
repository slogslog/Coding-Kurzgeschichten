using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaKebapAndDrinks
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza = new Pizza("Venezia", 6.5m, true);
            Kebap kebap = new Kebap("Ardana Kebap", 4.55m);
            Drink drink = new Drink("Cola", 3.5m, Volume._025l);
        }
    }
}
