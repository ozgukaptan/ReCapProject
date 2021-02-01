using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussines.Abstract
{
    public interface ICarService
    {
        CarDto GetAllCarsDtoById(IBrandDal brandDal, IColorDal colorDal , int Id);
        List<CarDto> GetAllCarsDto(IBrandDal brandDal,IColorDal colorDal);

        List<Car> GetAllCars();
    }
}
