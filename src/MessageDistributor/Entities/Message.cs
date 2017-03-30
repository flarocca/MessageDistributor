using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageDistributor.Entities
{
    public class Message
    {
        public int ProducerId { get; }
        public int ServiceId { get; }
        public int ActionId { get; }
        public dynamic Body { get; }

        public Message(int producerId, int serviceId, int actionId, dynamic body)
        {
            ProducerId = producerId;
            ServiceId = serviceId;
            ActionId = actionId;
            Body = body;
        }
    }
}
