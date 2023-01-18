using Parking.Domain.Core.Entities;
using Parking.Domain.Core.Repositories;
using Parking.Domain.Infra.Data;

namespace Parking.Domain.Infra.Repositories
{
    public class CarRepository : Repository<Car>, ICarRepository
    {
        public CarRepository(DataContext context) : base(context) { }
    }
}
