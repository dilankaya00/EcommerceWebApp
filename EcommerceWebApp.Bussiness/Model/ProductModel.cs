using EcommerceWebApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceWebApp.Bussiness.Model
{
    public class ProductModel:BaseModel
    {
        public int Id { get; set; }
        public CategoryModel CategoryModel { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public float Quantity { get; set; }
        public string Unit { get; set; }

    }
}
