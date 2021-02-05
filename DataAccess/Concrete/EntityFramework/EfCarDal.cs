using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccsess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Context;
using Entities.Concrete;
using Entities.Dtos;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapContext>, ICarDal
    {
        public List<CarDetail> GetCarDetails()
        {
            using (ReCapContext context = new ReCapContext())
            {
                var carDetailsList = from c in context.Cars
                             join b in context.Brands on c.BrandId equals b.Id
                             join co in context.Colors on c.ColorId equals co.Id
                             select new CarDetail
                             {
                                 Brand = b.Name,
                                 Color = co.Name,
                                 ModelYear = c.ModelYear,
                                 DealyPrice = c.DealyPrice,
                                 Description = c.Description
                             };
                return carDetailsList.ToList();
            }
        }
    }
}
