using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parking.Domain.Data;
using Parking.Domain.Repositories;
using Parking.Infra.Repositories;

namespace Parking.Infra.Data
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly DataContext _context;
        public ICarRepository CarRepository { get; }

        public UnitOfWork(DataContext context)
        {
            _context = context;
            CarRepository = new CarRepository(context);
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
