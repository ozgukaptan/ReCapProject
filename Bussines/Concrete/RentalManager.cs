using Bussines.Abstract;
using Bussines.Constants;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Bussines.Concrete
{
    public class RentalManager : IRentalService
    {
        private IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IDataResult<Rental> Add(Rental rental)
        {
            IResult result = BusinessRules.Run(CheckReturnDate(rental.CarId));

            if(result.Success)
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

       
        public IDataResult<Rental> Update(Rental rental)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Update(rental));
        }

        public IResult CheckCarRentable(Rental rental)
        {

            List<Rental> result = _rentalDal.GetList(x => x.CarId == rental.CarId && x.ReturnDate >= rental.RentDate || x.ReturnDate == null);
            if (!result.Count.Equals(0)) return new ErrorResult(Messages.RentalCarIsRented);
            return new SuccessResult();
        }

        //business rules
        private  IResult CheckReturnDate(int carId)
        {
            List<Rental> result = _rentalDal.GetList(x => x.CarId == carId &&  string.IsNullOrEmpty(x.ReturnDate.ToString()));
            if (!result.Count.Equals(0)) return new ErrorResult();
            return new SuccessResult();
        }

        
    }
}
