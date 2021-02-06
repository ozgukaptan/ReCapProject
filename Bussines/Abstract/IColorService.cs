using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Bussines.Abstract
{
    public interface IColorService
    {
        List<Color> GetAll();
        Color GetById(int id);
        Color Add(Color color);
        Color Update(Color color);
        void Delete(Color color);
    }
}
