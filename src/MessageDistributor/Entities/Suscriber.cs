using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageDistributor.Entities
{
    public enum SuscriberType
    {
        Producer = 1,
        Consumer = 2
    }

    public abstract class Suscriber
    {
        public SuscriberType Type { get; }
        public int Id { get; }

        protected Suscriber(int id, SuscriberType type)
        {
            Id = id;
            Type = type;
        }
    }
}
