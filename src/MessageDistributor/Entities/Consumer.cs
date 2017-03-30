using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageDistributor.Entities
{
    public class Consumer : Suscriber
    {
        public string UrlCallback { get; }

        public Consumer(int id, string urlCallback) : base(id, SuscriberType.Consumer)
        {
            UrlCallback = urlCallback;
        }

    }
}
