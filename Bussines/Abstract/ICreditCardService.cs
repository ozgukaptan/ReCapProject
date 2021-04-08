using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussines.Abstract
{
    public interface ICreditCardService 
    {
        IDataResult<List<CreditCard>> GetAll();
        IDataResult<List<CreditCard>> GetByUserId(int id);
        IResult Add(CreditCard creditCard);
        IResult Delete(CreditCard creditCard);
    }
}
