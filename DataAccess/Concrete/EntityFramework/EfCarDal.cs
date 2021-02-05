using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccsess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Context;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car,ReCapContext> , ICarDal
    {

    }
}
