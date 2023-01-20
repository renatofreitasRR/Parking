using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parking.Domain.Repositories;

namespace Parking.Domain.Data
{
    public interface IUnitOfWork
    {
        ICarRepository CarRepository { get; }
        IReadCarRepository ReadCarRepository { get; }

        Task CommitAsync();
    }
}
