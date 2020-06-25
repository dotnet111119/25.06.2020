using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    abstract class ToppingDecoratorBase : IPizza
    {
        public abstract string GetDetails();

        public abstract double GetPrice();

        protected IPizza pizza;

        public ToppingDecoratorBase(IPizza pizza)
        {
            this.pizza = pizza;
        }
    }
}
