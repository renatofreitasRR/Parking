using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Domain.Commands.Contracts
{
    public interface ICommand
    {
        public bool IsValid();
    }
}
