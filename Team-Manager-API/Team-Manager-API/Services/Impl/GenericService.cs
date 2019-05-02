using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamManagerApi.Model;

namespace TeamManagerApi.Services.Impl
{
    public class GenericService<T> : IGenericService<T>
    {
        private readonly IMongoCollection<T> _collection;

        public GenericService(IConfiguration config)
        {
            var client = new MongoClient(config.GetConnectionString("TeamManagerDb"));
            var database = client.GetDatabase("TeamManagerDb");
            _collection = database.GetCollection<T>(typeof(T).Name);
        }

        public T Create(T obj)
        {
            _collection.InsertOne(obj);
            return obj;
        }

        public IList<T> Get()
        {
            return _collection.Find(o => true).ToList();
        }

        public T Get(string id)
        {
            return _collection.Find<T>(o => Convert.ToString(o.GetType().GetProperty("Id").GetValue(o, null)) == id).FirstOrDefault();
        }

        public void Remove(string id)
        {
            _collection.DeleteOne(o => Convert.ToString(o.GetType().GetProperty("Id").GetValue(o, null)) == id);
        }

        public T Update(string id, T obj)
        {
            _collection.ReplaceOne(o => Convert.ToString(o.GetType().GetProperty("Id").GetValue(o, null)) == id, obj);
            return obj;
        }
    }
}
