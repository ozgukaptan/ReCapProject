using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryBrandDal : IBrandDal
    {
        List<Brand> _brands;
        public InMemoryBrandDal()
        {
            _brands = new List<Brand> {

                new Brand {Id = 1 , Name = "Mercedes" , Description = "Mercedes Açıklama"},
                new Brand {Id = 2 , Name = "Audi" , Description = "Audi Açıklama"},
                new Brand {Id = 3 , Name = "BMW" , Description = "BMW Açıklama"}

            };
        }
        public void Add(Brand brand)
        {
            _brands.Add(brand);
        }

        public void Delete(Brand brand)
        {
            Brand brandDelete = _brands.Where(b => b.Id == brand.Id).FirstOrDefault();
            _brands.Remove(brandDelete);
        }

        public List<Brand> GetAll()
        {
            return _brands.ToList();
        }

        public void Update(Brand brand)
        {
            Brand brandUpdate = _brands.Where(b => b.Id == brand.Id).FirstOrDefault();
            brandUpdate.Description = brand.Description;
            brandUpdate.Name = brand.Name;
        }
    }
}
