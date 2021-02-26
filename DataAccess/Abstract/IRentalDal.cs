using Core.DataAccsess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Entities.Dtos;

namespace DataAccess.Abstract
{
    public interface IRentalDal : IEntityRepository<Rental>
    { 
        List<RentalDetail> GetRentalDetails(Expression<Func<Rental, bool>> filter = null);
    }
}
