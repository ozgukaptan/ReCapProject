using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bussines.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Bussines.Concrete
{
    public class ColorManager :  IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public Color Add(Color color)
        {
            throw new NotImplementedException();
        }

        public void Delete(Color color)
        {
            throw new NotImplementedException();
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetList().ToList();
        }

        public Color GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Color Update(Color color)
        {
            throw new NotImplementedException();
        }
    }
}
