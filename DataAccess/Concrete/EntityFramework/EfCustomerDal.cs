using Core.DataAccsess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    class EfCustomerDal : EfEntityRepositoryBase<Customer,ReCapContext> , ICustomerDal
    {

    }
}
