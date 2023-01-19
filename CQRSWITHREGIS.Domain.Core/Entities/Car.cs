using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Domain.Entities
{
    public class Car : BaseEntity
    {
        public Car(string licensePlate)
        {
            LicensePlate = licensePlate;
            Registers = new List<Register>();
        }

        public string LicensePlate { get; private set; }
        public List<Register> Registers { get; private set; }
    }
}
