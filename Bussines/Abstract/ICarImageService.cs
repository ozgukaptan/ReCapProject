using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussines.Abstract
{
    public interface ICarImageService
    {
        IDataResult<CarImage> Add();
        IDataResult<List<CarImage>> GetAll();
        IDataResult<CarImage> GetCarImageById(int id);
        IDataResult<CarImage> Update();
        IResult Delete();
    }
}
