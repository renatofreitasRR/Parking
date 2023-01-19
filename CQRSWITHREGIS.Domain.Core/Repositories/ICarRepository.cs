using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parking.Domain.Entities;
using Parking.Domain.Repositories.Contracts;

namespace Parking.Domain.Repositories
{
    public interface ICarRepository : IRepository<Car>
    {
    }
}
