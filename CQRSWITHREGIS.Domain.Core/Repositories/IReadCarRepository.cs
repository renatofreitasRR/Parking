using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parking.Domain.ValueObject;

namespace Parking.Domain.Repositories
{
    public interface IReadCarRepository
    {
        IEnumerable<CarVO> Get();
    }
}
