using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccsess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Context;
using Entities.Concrete;
using Entities.Dtos;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        {
            using (ReCapContext context = new ReCapContext())
            {
                
                var carDetailsList = from c in filter == null ? context.Cars.Include(c => c.CarImages) : context.Cars.Include(c => c.CarImages).Where(filter)
                                     join b in context.Brands on c.BrandId equals b.Id
                                     join co in context.Colors on c.ColorId equals co.Id
                                     select new CarDetailDto
                                     {
                                         BrandId = b.Id,
                                         Brand = b.Name,
                                         ColorId = co.Id,
                                         Color = co.Name,
                                         ModelYear = c.ModelYear,
                                         DealyPrice = c.DealyPrice,
                                         Description = c.Description,
                                         carImages = c.CarImages
                                     };
                return carDetailsList.ToList();
            }
        }
    }
}
