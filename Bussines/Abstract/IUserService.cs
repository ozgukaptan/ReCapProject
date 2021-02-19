using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussines.Abstract
{
    public interface IUserService
    {
        IDataResult<User> Add(User user);
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetUserById(int id);
        IDataResult<User> Update(User user);
        IResult Delete(User user);
    }
}
