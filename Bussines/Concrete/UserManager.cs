using Bussines.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using Bussines.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using FluentValidation;
using Core.Entities.Concrete;
using Core.Aspects.Autofac.Caching;
using Bussines.BusinessAspects.Autofac;

namespace Bussines.Concrete
{
    public class UserManager : IUserService
    {

        IUserDal _UserDal;

        public UserManager(IUserDal userDal)
        {
            _UserDal = userDal;
        }

        
        [ValidationAspect(typeof(UserValidator))]
        public IDataResult<User> Add(User user)
        {
            return new SuccessDataResult<User>(_UserDal.Add(user));
        }

        public IResult Delete(User user)
        {
            _UserDal.Delete(user);
            return new SuccessResult();
        }

        [CacheAspect]
        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_UserDal.GetList());
        }

        public IDataResult<User> GetByMail(string email)
        {
            return new SuccessDataResult<User>(_UserDal.Get(u => u.Email == email));
        }

        public IDataResult<List<OperationClaim>> GetClaims(User user)
        {
            return new SuccessDataResult<List<OperationClaim>>(_UserDal.GetClaims(user));
        }

        

        public IDataResult<User> GetUserById(int id)
        {
            return new SuccessDataResult<User>(_UserDal.Get(u=>u.Id==id));
        }

        public IDataResult<User> Update(User user)
        {
            return new SuccessDataResult<User>(_UserDal.Update(user)); 
        }
    }
}
