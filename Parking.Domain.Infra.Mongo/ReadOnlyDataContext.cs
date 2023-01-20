using MongoDB.Driver;
using Parking.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Infra.Read
{
    public class ReadOnlyDataContext
    {
        private readonly IMongoDatabase _mongoDatabase;
        private readonly string _collectionName;

        public ReadOnlyDataContext(string collection)
        {
            var client = new MongoClient("mongodb://localhost:27017");
            _mongoDatabase = client.GetDatabase("parking"); ;
            _collectionName = collection;
        }

        protected IMongoCollection<T> GetCollection<T>()
            => _mongoDatabase.GetCollection<T>(_collectionName);

        public virtual IQueryable<T> Get<T>()
            => GetCollection<T>().AsQueryable();
    }
}
