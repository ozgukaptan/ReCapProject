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
        List<CarDto> GetAllCarsDto(IBrandDal brandDal,IColorDal colorDal);

        List<Car> GetAllCars();
    }
}
