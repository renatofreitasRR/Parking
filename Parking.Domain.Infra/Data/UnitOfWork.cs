using Parking.Domain.Data;
using Parking.Domain.Repositories;
using Parking.Infra.Read.Repositories;
using Parking.Infra.Write.Repositories;

namespace Parking.Infra.Write.Data
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly DataContext _context;
        public ICarRepository CarRepository { get; }
        public IReadCarRepository ReadCarRepository { get; }

        public UnitOfWork(DataContext context)
        {
            _context = context;
            CarRepository = new CarRepository(context);
            ReadCarRepository = new ReadCarRepository();
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
