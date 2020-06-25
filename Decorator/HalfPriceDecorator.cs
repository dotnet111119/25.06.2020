using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class HalfPriceDecorator : ToppingDecoratorBase
    {
        public HalfPriceDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string GetDetails()
        {
            return pizza.GetDetails() + " half price";
        }

        public override double GetPrice()
        {
            return pizza.GetPrice() / 2.0;
        }
    }
}