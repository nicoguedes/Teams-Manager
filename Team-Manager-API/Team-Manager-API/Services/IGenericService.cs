using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamManagerApi.Services
{
    public interface IGenericService<T>
    {
        IList<T> Get();
        T Get(string id);
        T Create(T obj);
        T Update(string id, T obj);
        void Remove(string id);
    }
}
