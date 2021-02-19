using Bussines.Abstract;
using Bussines.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussines.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IDataResult<Rental> Add(Rental rental)
        {
            if(CheckReturnDate(rental.CarId).Success)
                return new SuccessDataResult<Rental>(_rentalDal.Add(rental)); 
            else
                return new ErrorDataResult<Rental>(Messages.RentalCarInvalid);
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult();
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetList());
        }

        public IDataResult<Rental> GetRentalById(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.Id == id));
        }
        public IResult CheckReturnDate(int carId)
        {
            List<Rental> result = _rentalDal.GetList(x => x.CarId == carId && x.ReturnDate == null);
            if (result.Count > 0) return new ErrorResult();
            return new SuccessResult();
        }


        public IDataResult<Rental> Update(Rental rental)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Update(rental));
        }

        
    }
}
