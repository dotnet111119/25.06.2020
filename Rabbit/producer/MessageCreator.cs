using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabbit
{
    static class MessageCreator
    {
        public static RequestMessage CreateAddFlightCommand(string invoker, DateTime flightTime,
            string origin, string dest)
        {
            return new RequestMessage
            {
                RequestTime = DateTime.Now,
                OperationName = "AddFlight",
                Invoker = invoker,
                Data = new
                {
                    FlightTime = flightTime,
                    Origin = origin,
                    Destination = dest
                }
            };
        }
        
    }
}
