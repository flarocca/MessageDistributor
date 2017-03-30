using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using MessageDistributor.Entities;

namespace MessageDistributor.Repositories
{
    public interface IRepository<T>
    {
        T Get(int id);
        void Save(T elem);

        void Delete(int id);
    }
}
