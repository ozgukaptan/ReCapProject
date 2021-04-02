using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
    public class RentalPaymentDto
    {
        public Payment Payment { get; set; }
        public Rental Rental { get; set; }
    }
}
