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
        List<Car> GetCarsByBrandId(int id);
        List<Car> GetCarsByColorId(int id);
        List<Car> GetAll();
        List<CarDetail> GetAllCarDetail();
        Car GetById(int id);

        Car Add(Car car);

        Car Update(Car car);
        void Delete(Car car);
    }
}
