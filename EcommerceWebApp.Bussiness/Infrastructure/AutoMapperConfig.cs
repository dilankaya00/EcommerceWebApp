using AutoMapper;
using EcommerceWebApp.Bussiness.Model;
using EcommerceWebApp.Database.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceWebApp.Bussiness.Infrastructure
{
   public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Product, ProductModel>().ReverseMap();
            CreateMap<Category, CategoryModel>().ReverseMap();
            
        }
    }
}
