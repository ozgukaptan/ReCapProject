using Bussines.Abstract;
using Bussines.Constants;
using Core.Aspects.Autofac.Caching;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussines.Concrete
{
    public class PaymentManager : IPaymentService
    {
        private IRentalService _rentalService;
        public PaymentManager(IRentalService rentalService)
        {
            _rentalService = rentalService;
        }

        [TransactionScopeAspect]
        public IResult ReceivePayment(Payment payment,Rental rental)
        {
            if(payment.Amount > 10000)
            {
                return new ErrorResult(Messages.InsufficientBalance);
            }
            else if(_rentalService.Add(rental).Success)
            { return new SuccessResult(Messages.PaymentCompleted); }
            else { return new ErrorResult(); }
            
            
            
        }
    }
}
