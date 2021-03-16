using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;

namespace Bussines.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetCarsByBrandId(int id);
        IDataResult<List<Car>> GetCarsByColorId(int id);
        IDataResult<CarDetailDto> GetCarsByIdDetail(int id);
        IDataResult<List<CarDetailDto>> GetCarsByBrandIdDetail(int id);
        IDataResult<List<CarDetailDto>> GetCarsByColorIdDetail(int id);
        IDataResult<List<Car>> GetAll();
        IDataResult<List<CarDetailDto>> GetAllCarDetail();
        IDataResult<Car> GetById(int id);
        IResult Add(Car car);
        IDataResult<Car> Update(Car car);
        IResult Delete(Car car);
    }
}
