using Core.DataAccsess;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{

    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
            new Car{Id = 1, BrandId = 1 , ColorId = 1 , DealyPrice = 600 , Description = "Araba açıklama" , ModelYear = "1990"},
            new Car{Id = 2, BrandId = 1 , ColorId = 2 , DealyPrice = 700 , Description = "Araba açıklama" , ModelYear = "1991"},
            new Car{Id = 3, BrandId = 2 , ColorId = 1 , DealyPrice = 750 , Description = "Araba açıklama" , ModelYear = "1992"},
            new Car{Id = 4, BrandId = 2 , ColorId = 3 , DealyPrice = 800 , Description = "Araba açıklama" , ModelYear = "1993"},
            new Car{Id = 5, BrandId = 3 , ColorId = 2 , DealyPrice = 900 , Description = "Araba açıklama" , ModelYear = "1994"},
            new Car{Id = 6, BrandId = 3 , ColorId = 4 , DealyPrice = 1100 , Description = "Araba açıklama" , ModelYear = "1995"}
            };

        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carDelete = _cars.Where(c => c.Id == car.Id).FirstOrDefault();
            _cars.Remove(carDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllByBrandId(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public List<CarDetail> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public List<Car> GetList(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carUpdate = _cars.Where(c => c.Id == car.Id).FirstOrDefault();
            carUpdate.BrandId = car.BrandId;
            carUpdate.ColorId = car.ColorId;
            carUpdate.DealyPrice = car.DealyPrice;
            carUpdate.Description = car.Description;
            carUpdate.ModelYear = car.ModelYear;
        }

        Car IEntitiyRepository<Car>.Add(Car entity)
        {
            throw new NotImplementedException();
        }

        Car IEntitiyRepository<Car>.Update(Car entity)
        {
            throw new NotImplementedException();
        }
    }
}
