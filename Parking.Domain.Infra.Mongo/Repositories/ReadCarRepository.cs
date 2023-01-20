using MongoDB.Driver;
using Parking.Domain.Repositories;
using Parking.Domain.ValueObject;
using Parking.Infra.Read.Entities;

namespace Parking.Infra.Read.Repositories
{
    public class ReadCarRepository : ReadOnlyDataContext, IReadCarRepository
    {
        public ReadCarRepository() : base("Cars")
        {
        }

        public IEnumerable<CarVO> Get()
        {
            var list = this.GetCollection<CarData>()
                .Find(x => true)
                .ToList()
                .Select(x => new CarVO()
                {
                    Id = x.Id,
                    Name = x.Name,
                });

            return list;
        }
    }
}
