using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class BulgaritTopping : ToppingDecoratorBase
    {
        public BulgaritTopping(IPizza pizza) : base(pizza)
        {
        }

        public override string GetDetails()
        {
            return pizza.GetDetails() + " bulgarit";
        }

        public override double GetPrice()
        {
            return 6.0 + pizza.GetPrice();
        }
    }
}