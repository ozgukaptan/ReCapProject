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
                Console.WriteLine("Araba renginin isim alanına iki karekterden büyük bir şey yazın.");
                return null;
            }
        }

        public void Delete(Brand brand)
        {
            _brandDal.Delete(brand);
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetList();
        }

        public Brand GetById(int id)
        {
            return _brandDal.Get(b => b.Id == id);
        }

        public Brand Update(Brand brand)
        {
            return _brandDal.Update(brand);
        }
    }
}
