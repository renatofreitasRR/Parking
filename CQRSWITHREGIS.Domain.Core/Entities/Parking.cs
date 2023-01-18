using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Domain.Core.Entities
{
    public class Parking : BaseEntity
    {
        public Parking(string address)
        {
            Address = address;
            Registers = new List<Register>();
        }
        public int TotalVacancies { get; private set; }
        public string Address { get; private set; }
        public List<Register> Registers { get; private set; }
    }
}
