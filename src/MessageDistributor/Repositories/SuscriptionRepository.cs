using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MessageDistributor.Entities;

namespace MessageDistributor.Repositories
{
    public class SuscriptionRepository : IRepository<Suscription>
    {
        Suscription IRepository<Suscription>.Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(Suscription elem)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
