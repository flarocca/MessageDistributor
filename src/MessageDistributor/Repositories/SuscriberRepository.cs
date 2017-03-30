using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MessageDistributor.Entities;

namespace MessageDistributor.Repositories
{
    public class SuscriberRepository : IRepository<Suscriber>
    {
        public Suscriber Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Suscriber> GetConsumersByServiceAndAction(int serviceId, int actionId)
        {
            throw new NotImplementedException();
        }

        public void Save(Suscriber elem)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
