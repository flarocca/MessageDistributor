using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageDistributor.Entities
{
    public class Producer : Suscriber
    {
        public Producer(int id) : base(id, SuscriberType.Producer)
        {
        }
    }
}
