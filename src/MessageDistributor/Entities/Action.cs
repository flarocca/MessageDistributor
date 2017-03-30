using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageDistributor.Entities
{
    public class Action
    {
        public int ServiceId { get; }
        public int Id { get; }
        public string Type { get; }
        public string Name { get; }

        public Action(int serviceId, int id, string type, string name)
        {
            ServiceId = serviceId;
            Id = id;
            Type = type;
            Name = name;
        }
    }
}
