using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageDistributor.Entities
{
    public class Suscription
    {
        public int SuscriberId { get; }
        public int ServiceId { get; }
        public IEnumerable<int> Actions { get; }

        public Suscription(int suscriberId, int serviceId, IEnumerable<int> actions)
        {
            ServiceId = serviceId;
            SuscriberId = suscriberId;
            Actions = actions;
        }
    }
}
