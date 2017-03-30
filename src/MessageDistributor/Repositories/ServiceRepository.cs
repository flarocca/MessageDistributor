using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MessageDistributor.Entities;

namespace MessageDistributor.Repositories
{
    public class ServiceRepository : IRepository<Service>
    {
        Service IRepository<Service>.Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(Service elem)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
