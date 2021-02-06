using Bussines.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Abstract;

namespace Bussines.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        
        public Brand Add(Brand brand)
        {
            if (brand.Name.Length >= 2)
            {
                return _brandDal.Add(brand);
            }
            else
            {
                Console.WriteLine("Araba renginin ism alanına iki karekterden büyük bir şey yazın.");
                return null;
            }
        }

        public void Delete(Brand brand)
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetAll()
        {
            throw new NotImplementedException();
        }

        public Brand GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public Brand Update(Brand brand)
        {
            throw new NotImplementedException();
        }
    }
}
