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
            Console.OutputEncoding = Encoding.Unicode;

            Product pizza = new Pizza("Venezia", 6.5m, true);
            Product kebap = new Kebap("Ardana Kebap", 4.55m);
            Product drink = new Drink("Cola", 3.5m, Volume._05l);

            List<Product> products = new List<Product>();
            products.Add(pizza);
            products.Add(kebap);
            products.Add(drink);

            foreach ( Product p in products )
            {
                Console.WriteLine(p);
                Console.WriteLine($"   Preparation time: {p.GetMinutes()} min");
                Console.WriteLine($"   Ingredients price: {p.GetIngredientsCosts():C2}");
            }

            Console.ReadKey();
        }
    }
}
