using Bussines.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bussines.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public Car Add(Car car)
        {
            return _carDal.Add(car);
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetList();
        }

        public List<CarDetail> GetAllCarDetail()
        {
            return _carDal.GetCarDetails();
        }

        public Car GetById(int Id)
        {
            return _carDal.Get(c => c.Id == Id);
        }

        public Car Update(Car car)
        {
            return _carDal.Update(car);
        }

        List<Car> ICarService.GetAllCarDetail()
        {
            throw new NotImplementedException();
        }
    }
}
