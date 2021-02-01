﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
    public class CarDto :IDto
    {
        public string Brand { get; set; }
        public string Color { get; set; }
        public int ModelYear { get; set; }
        public decimal DealyPrice { get; set; }
        public string Description { get; set; }
    }
}
