using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Bussines.Abstract
{
    interface IBrandService
    {
        IDataResult<List<Brand>> GetAll();
        IDataResult<Brand> GetById(int id);
        IResult Add(Brand brand);
        IDataResult<Brand> Update(Brand brand);
        IResult Delete(Brand brand);
    }
}
