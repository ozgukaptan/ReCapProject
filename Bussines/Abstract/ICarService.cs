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
        List<Car> GetAll();
        List<Car> GetAllCarDetail();
        Car GetById(int Id);
        Car Add(Car car);
        Car Update(Car car);
        void Delete(Car car);
    }
}
