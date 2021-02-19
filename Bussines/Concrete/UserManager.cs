using Bussines.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussines.Concrete
{
    public class UserManager : IUserService
    {

        IUserDal _UserDal;

        public UserManager(IUserDal userDal)
        {
            _UserDal = userDal;
        }


        public IDataResult<User> Add(User user)
        {
            return new SuccessDataResult<User>(_UserDal.Add(user));
        }

        public IResult Delete(User user)
        {
            _UserDal.Delete(user);
            return new SuccessResult();
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_UserDal.GetList());
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
