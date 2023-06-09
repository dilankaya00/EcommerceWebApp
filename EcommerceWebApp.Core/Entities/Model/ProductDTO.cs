﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceWebApp.Core.Entities.Model
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public CategoryDTO Category { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public float Quantity { get; set; }
        public string Unit { get; set; }
    }
}
