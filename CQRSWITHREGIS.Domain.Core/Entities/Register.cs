using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Domain.Entities
{
    public class Register : BaseEntity
    {
        public Register(Car car, decimal value, DateTime checkInDateTime, DateTime checkOutDateTime)
        {
            Car = car;
            Value = value;
            CheckInDateTime = checkInDateTime;
            CheckOutDateTime = checkOutDateTime;
        }

        public Car Car { get; private set; }
        public decimal Value { get; private set; }
        public DateTime CheckInDateTime { get; private set; }
        public DateTime CheckOutDateTime { get; private set; }
    }
}
