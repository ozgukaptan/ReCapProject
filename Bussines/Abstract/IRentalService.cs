using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussines.Abstract
{
    interface IRentalService
    {
        IDataResult<Rental> Add(Rental rental);
        IDataResult<List<Rental>> GetAll();
        IDataResult<Rental> GetRentalById();
        IDataResult<Rental> Update(Rental rental);
        IResult Delete(Rental rental);
    }
}
