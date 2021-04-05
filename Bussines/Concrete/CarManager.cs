using Bussines.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bussines.Constants;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;

namespace Bussines.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Car car)
        {
            if (car.DealyPrice > 0)
            {
                _carDal.Add(car);
                return new SuccessResult(Messages.CarAdded);
            }
            else
            {
                
                return new ErrorResult();
            }
                
        }
        
        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult();
        }

        public  IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetList());
        }

        public IDataResult<List<CarDetailDto>> GetAllCarDetail()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }

        public IDataResult<Car> GetById(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.Id == id));
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetList(c => c.BrandId == brandId).ToList());
        }

        public IDataResult<List<Car>> GetCarsByColorId(int colorId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetList(c => c.ColorId == colorId).ToList());
        }

        public IDataResult<List<CarDetailDto>> GetCarsByBrandIdDetail(int id)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(c => c.BrandId == id).ToList());
        }

        public IDataResult<List<CarDetailDto>> GetCarsByColorIdDetail(int id)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(c => c.ColorId == id).ToList());
        }

        public IDataResult<Car>  Update(Car car)
        {
            return new SuccessDataResult<Car>(_carDal.Update(car),Messages.CarUpdated);
        }

        public IDataResult<CarDetailDto> GetCarsByIdDetail(int id)
        {
            return new SuccessDataResult<CarDetailDto>(_carDal.GetCarDetails(c => c.Id == id).FirstOrDefault());
        }

        public IDataResult<List<CarDetailDto>> GetCarsByBrandAndColorIdDetail(int brandId, int colorId)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(c => c.BrandId == brandId && c.ColorId == colorId).ToList());
        }
    }
}
