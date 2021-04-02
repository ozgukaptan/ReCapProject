using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussines.Abstract
{
    public interface IRentalService
    {
        IDataResult<Rental> Add(Rental rental);
        IDataResult<List<Rental>> GetAll();
        IDataResult<Rental> GetRentalById(int id);
        IDataResult<Rental> Update(Rental rental);
        IResult Delete(Rental rental);

        IResult CheckCarRentable(Rental rental);

    }
}
