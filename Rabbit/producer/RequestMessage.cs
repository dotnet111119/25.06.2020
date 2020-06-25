using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabbit
{
    class RequestMessage
    {
        public DateTime RequestTime { get; set; }
        public string OperationName { get; set; }
        public object Data { get; set; }
        public string Invoker { get; set; }
    }
}
