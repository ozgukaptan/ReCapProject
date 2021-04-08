using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Concrete
{
    public class Car : IEntity
    {
        public Car()
        {
            CarImages = new List<CarImage>();
        }
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public string ModelYear { get; set; }
        public int DealyPrice { get; set; }
        public string Description { get; set; }
        public List<CarImage> CarImages { get; set; }
        public int? FindeksPoint { get; set; }

    }
}
