using EcommerceWebApp.Bussiness.Model;
using EcommerceWebApp.Bussiness.Services;
using EcommerceWebApp.Database.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceWebApp.API.Controllers
{
    public class CategoriesController : BaseController<CategoryModel, Category>
    {
        public CategoriesController(ICategoryService categoryService) : base(categoryService)
        {

        }

    }
}
