using Bussines.Abstract;
using Bussines.Constants;
using Core.Aspects.Autofac.Caching;
using Core.Utilities.Business;
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
            IResult result = BusinessRules.Run(checkCreditLimit(payment));

            if (result.Success) {
                _rentalService.Add(rental);
                return new SuccessResult(Messages.PaymentCompleted);
            }
            else
            {
                return new ErrorResult(result.Message);
            }
        }

        // bussines roule

        private IResult checkCreditLimit(Payment payment)
        {
            if (payment.Amount > 10000)
            {
                return new ErrorResult(Messages.InsufficientBalance);
            }
            else
            {
                return new SuccessResult();
            }
        }
    }
}
