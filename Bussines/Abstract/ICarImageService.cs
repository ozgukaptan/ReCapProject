using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussines.Abstract
{
    public interface ICarImageService
    {
        IDataResult<CarImage> Add(IFormFile file, CarImage carImage);
        IDataResult<List<CarImage>> GetAll();
        IDataResult<CarImage> GetCarImageById(int id);
        IDataResult<CarImage> Update();
        IResult Delete();
    }
}
