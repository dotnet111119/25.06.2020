using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IPizza basePizza = new BasePizza();

            // redundent
            IPizza basePizzaWithCheese = new CheeseToppings(basePizza);

            // important -- only this i need reference for
            IPizza pizzaWithCheeseAndTomato = new TomatoTopping(basePizzaWithCheese);

            Console.WriteLine(pizzaWithCheeseAndTomato.GetDetails());
            Console.WriteLine(pizzaWithCheeseAndTomato.GetPrice());

            IPizza pizzaWithPineappleAndTomatoAndBulgarit =
                new BulgaritTopping(new TomatoTopping(new PineappleDecorator(new BasePizza())));

            Console.WriteLine(pizzaWithPineappleAndTomatoAndBulgarit.GetDetails());
            Console.WriteLine(pizzaWithPineappleAndTomatoAndBulgarit.GetPrice());
        }
    }
}
