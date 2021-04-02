using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussines.Abstract
{
    public interface IPaymentService
    {
        IResult ReceivePayment(Payment payment,Rental rental);
    }
}
