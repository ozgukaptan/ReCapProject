using Bussines.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public Car Add(Car car)
        {
            if (car.DealyPrice > 0)
            {
                return _carDal.Add(car);
            }
            else
            {
                Console.WriteLine("Arabanın günlük fiyatı 0 dan büyük olmalıdır.");
                return null;
            }
                
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

        public Car GetById(int id)
        {
            return _carDal.Get(c => c.Id == id);
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetList(c=>c.BrandId==id).ToList();
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetList(c => c.ColorId == id).ToList();
        }

        public Car Update(Car car)
        {
            return _carDal.Update(car);
        }

        
    }
}
