using Parking.Domain.Entities;
using Parking.Domain.Repositories;
using Parking.Infra.Data;

namespace Parking.Infra.Repositories
{
    public class CarRepository : Repository<Car>, ICarRepository
    {
        public CarRepository(DataContext context) : base(context) { }
    }
}
