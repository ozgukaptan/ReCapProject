using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Bussines.Abstract
{
    interface IBrandService
    {
        List<Brand> GetAll();
        Brand GetById(int Id);
        Brand Add(Brand brand);
        Brand Update(Brand brand);
        void Delete(Brand brand);
    }
}
