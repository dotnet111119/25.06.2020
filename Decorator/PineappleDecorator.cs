using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class PineappleDecorator : ToppingDecoratorBase
    {
        public PineappleDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string GetDetails()
        {
            return pizza.GetDetails() + " pineapple";
        }

        public override double GetPrice()
        {
            return 8.0 + pizza.GetPrice();
        }
    }
}