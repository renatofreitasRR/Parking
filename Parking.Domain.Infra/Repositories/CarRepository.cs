using Parking.Domain.Entities;
using Parking.Domain.Repositories;
using Parking.Infra.Write.Data;

namespace Parking.Infra.Write.Repositories
{
    public class CarRepository : Repository<Car>, ICarRepository
    {
        public CarRepository(DataContext context) : base(context) { }
    }
}
