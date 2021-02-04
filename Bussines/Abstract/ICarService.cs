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
        CarDetail GetAllCarsDtoById(IBrandDal brandDal, IColorDal colorDal , int Id);
        List<CarDetail> GetAllCarsDto(IBrandDal brandDal,IColorDal colorDal);

        List<Car> GetAllCars();
    }
}
