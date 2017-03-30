using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageDistributor.Entities
{
    public class Service
    {
        public int Id { get; }
        public IEnumerable<int> Actions { get;}

        public Service(int id, IEnumerable<int> actions)
        {
            Actions = actions;
            Id = id;
        }
    }
}
