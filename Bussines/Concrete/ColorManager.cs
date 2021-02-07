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
            return _colorDal.Add(color);
        }

        public void Delete(Color color)
        {
            _colorDal.Delete(color);
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetList().ToList();
        }

        public Color GetById(int id)
        {
            return _colorDal.Get(c => c.Id == id);
        }

        public Color Update(Color color)
        {
            return _colorDal.Update(color);
        }
    }
}
