using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parking.Domain.Commands.Contracts;

namespace Parking.Domain.Handlers.Contracts
{
    public interface IHandler<T> where T : ICommand
    {
        Task Handle(T command);
    }
}
