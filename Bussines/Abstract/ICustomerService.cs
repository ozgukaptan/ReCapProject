using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussines.Abstract
{
    public interface ICustomerService 
    {
        IDataResult<Customer> Add(Customer customer);
        IDataResult<List<Customer>> GetAll();
        IDataResult<Customer> GetCustomerById();
        IDataResult<Customer> Update(Customer customer);
        IResult Delete(Customer customer);
    }
}
