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

            Pizza pizza = new Pizza("Venezia", 6.5m, true);
            Kebap kebap = new Kebap("Ardana Kebap", 4.55m);
            Drink drink = new Drink("Cola", 3.5m, Volume._05l);

            Console.WriteLine(pizza);
            Console.WriteLine($"   Preparation time: {pizza.GetMinutes()} min");
            Console.WriteLine($"   Ingredients price: {pizza.GetIngredientsCosts():C2}");

            Console.WriteLine(kebap);
            Console.WriteLine($"   Preparation time: {kebap.GetMinutes()} min");
            Console.WriteLine($"   Ingredients price: {kebap.GetIngredientsCosts():C2}");

            Console.WriteLine(drink);
            Console.WriteLine($"   Preparation time: {drink.GetMinutes()} min");
            Console.WriteLine($"   Ingredients price: {drink.GetIngredientsCosts():C2}");

            Console.ReadKey();
        }
    }
}
