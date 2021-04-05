using Bussines.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Bussines.Constants;
using Core.Utilities.Results;
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

        
        public IResult Add(Brand brand)
        {
            if (brand.Name.Length < 2)
            {
                
                return new ErrorResult(Messages.BrandNameInvalid);
            }
            else
            {
                _brandDal.Add(brand);
                return new SuccessResult(Messages.BrandAdded);
            }
        }

        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult(Messages.BrandDeleted);
        }

        public IDataResult<List<Brand>> GetAll()
        {
            
            return new SuccessDataResult<List<Brand>>(_brandDal.GetList());
        }

        public IDataResult<Brand> GetById(int id)
        { 
            
            return new SuccessDataResult<Brand>(_brandDal.Get(b => b.Id == id));
        }

        public IDataResult<Brand> Update(Brand brand)
        {
            return new SuccessDataResult<Brand>(_brandDal.Update(brand),Messages.BrandUpdated);
        }
    }
}
