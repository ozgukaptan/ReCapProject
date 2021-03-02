﻿using Bussines.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Abstract;
using Core.Aspects.Autofac.Validation;
using Bussines.ValidationRules.FluentValidation;
using Core.Utilities.Business;
using Bussines.Constants;
using Core.Utilities.Helpers;
using Microsoft.AspNetCore.Http;

namespace Bussines.Concrete
{
    public class CarImageManager : ICarImageService
    {
        private  ICarImageDal _carImageDal;

        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }
        
        [ValidationAspect(typeof(CarImageValidator))]
        public IDataResult<CarImage> Add(IFormFile file, CarImage carImage)
        {
            IResult result = BusinessRules.Run(CheckImageLimitExceeded(carImage.CarId));

            if(result != null)
            {
                return new ErrorDataResult<CarImage>(result.Message);
            }

            carImage.ImagePath = FileHelpers.Add(file);
            carImage.Date = DateTime.Now;
            
            return new SuccessDataResult<CarImage>(_carImageDal.Add(carImage));
        }

        

        public IResult Delete()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<CarImage> GetCarImageById(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<CarImage> Update()
        {
            throw new NotImplementedException();
        }

        // Business Rules

        private IResult CheckImageLimitExceeded(int carId)
        {
            var carImageCount = _carImageDal.GetList(p => p.CarId == carId).Count;
            if(carImageCount>=5)
            {
                return new ErrorResult(Messages.CarImageLimitExceeded);
            }
            return new SuccessResult();
        }
    }
}
