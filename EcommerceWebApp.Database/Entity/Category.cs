﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceWebApp.Database.Entity
{
    public class Category
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        public string Description{ get; set; }
        public List<Product> Product { get; set; }
    }
}
