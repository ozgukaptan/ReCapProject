using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccsess;
using Entities.Dtos;

namespace DataAccess.Abstract
{
    public interface ICarDal : IEntitiyRepository<Car>
    {
        List<CarDetail> GetCarDetails();
    }
}
