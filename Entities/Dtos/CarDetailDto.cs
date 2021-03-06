﻿using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
    public class CarDetailDto :IDto
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public string ModelYear { get; set; }
        public int DealyPrice { get; set; }
        public string Description { get; set; }
        public int? FindeksPoint { get; set; }
        public List<CarImage> CarImages { get; set; }
    }
}
