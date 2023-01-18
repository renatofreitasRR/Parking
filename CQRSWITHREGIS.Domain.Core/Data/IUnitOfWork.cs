using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parking.Domain.Core.Repositories;

namespace Parking.Domain.Core.Data
{
    public interface IUnitOfWork
    {
        ICarRepository CarRepository { get; }
        Task CommitAsync();
    }
}
