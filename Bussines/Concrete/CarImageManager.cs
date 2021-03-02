using Bussines.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Abstract;

namespace Bussines.Concrete
{
    public class CarImageManager : ICarImageService
    {
        private  ICarImageDal _carImageDal;

        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }
        
        public IDataResult<CarImage> Add(CarImage carImage)
        {
            carImage.Date = System.DateTime.Now;
            return null;
        }

        public IResult Delete()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<CarImage> GetCarImageById(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<CarImage> Update()
        {
            throw new NotImplementedException();
        }
    }
}
