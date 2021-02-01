using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryColorDal : IColorDal
    {
        List<Color> _colors;
        public InMemoryColorDal()
        {
            _colors = new List<Color> {

                new Color{ Id = 1 , Name = "lacivert" , Description = "Lacivert"},
                new Color{ Id = 2 , Name = "Sarı" , Description = "Sarı"},
                new Color{ Id = 3 , Name = "Beyaz" , Description = "Beyaz"},
                new Color{ Id = 4 , Name = "Yaşil" , Description = "Yaşil"}

            };
        }

        public void Add(Color color)
        {
            _colors.Add(color);
        }

        public void Delete(Color color)
        {
            Color colorDelete = _colors.Where(c => c.Id == color.Id).FirstOrDefault();
            _colors.Remove(colorDelete);
        }

        public List<Color> GetAll()
        {
            return _colors.ToList();
        }

        public void Update(Color color)
        {
            Color colorUpdate = _colors.Where(c => c.Id == color.Id).FirstOrDefault();
            colorUpdate.Description = color.Description;
            colorUpdate.Name = color.Name;
        }
    }
}
