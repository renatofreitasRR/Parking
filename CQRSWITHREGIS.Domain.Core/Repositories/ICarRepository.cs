﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parking.Domain.Core.Entities;
using Parking.Domain.Core.Repositories.Contracts;

namespace Parking.Domain.Core.Repositories
{
    public interface ICarRepository : IRepository<Car>
    {
    }
}
