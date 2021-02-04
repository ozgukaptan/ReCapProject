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

        public List<Car> GetAllCars()
        {
           return _carDal.GetAll();
        }
        
        public List<CarDetail> GetAllCarsDto(IBrandDal brandDal, IColorDal colorDal)
        {
            List<Car> cars = _carDal.GetAll();
            List<Brand> brands = brandDal.GetAll();
            List<Color> colors = colorDal.GetAll();

            var result = from c in cars
                         join b in brands on c.BrandId equals b.Id
                         join co in colors on c.ColorId equals co.Id
                         select new CarDetail
                         {
                             Brand = b.Name, Color = co.Name , ModelYear = c.ModelYear , DealyPrice = c.DealyPrice , Description = c.Description
                         };

            return result.ToList();
        }


        public CarDetail GetAllCarsDtoById(IBrandDal brandDal, IColorDal colorDal,int Id)
        {
            List<Car> cars = _carDal.GetAll();
            List<Brand> brands = brandDal.GetAll();
            List<Color> colors = colorDal.GetAll();

            var result = from c in cars
                         join b in brands on c.BrandId equals b.Id
                         join co in colors on c.ColorId equals co.Id
                         where c.Id == Id
                         select new CarDetail
                         {
                             Brand = b.Name,
                             Color = co.Name,
                             ModelYear = c.ModelYear,
                             DealyPrice = c.DealyPrice,
                             Description = c.Description
                         };

            return result.FirstOrDefault();
        }


        public void Add(Car car)
        {
            _carDal.Add(car);
        }

        public void update(Car car)
        {
            _carDal.Update(car);
        }

        public void delete(Car car)
        {
            _carDal.Delete(car);
        }
    }
}
