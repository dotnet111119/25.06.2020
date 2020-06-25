using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class TomatoTopping : ToppingDecoratorBase
    {
        public TomatoTopping(IPizza pizza) : base(pizza)
        {
        }

        public override string GetDetails()
        {
            return pizza.GetDetails() + " tomato";
        }

        public override double GetPrice()
        {
            return 3.0 + pizza.GetPrice();
        }
    }
}