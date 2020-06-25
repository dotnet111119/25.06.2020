using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class CheeseToppings : ToppingDecoratorBase
    {
        public CheeseToppings(IPizza pizza) : base(pizza)
        {
        }

        public override string GetDetails()
        {
            return pizza.GetDetails() + " cheese";
        }

        public override double GetPrice()
        {
            return 4.0 + pizza.GetPrice();
        }
    }
}
