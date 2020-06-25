using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class BasePizza : IPizza
    {
        public string GetDetails()
        {
            return "base pizza plain crasp doe";
        }

        public double GetPrice()
        {
            return 40.0;
        }
    }
}
