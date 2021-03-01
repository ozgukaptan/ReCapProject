using Bussines.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussines.Concrete
{
    public class CarImageManager : ICarImageService
    {

        public CarImageManager()
        {
                
        }
        public IDataResult<CarImage> Add(CarImage carImage)
        {
            throw new NotImplementedException();
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
