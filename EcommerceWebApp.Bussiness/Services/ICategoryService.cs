﻿using EcommerceWebApp.Bussiness.Model;
using EcommerceWebApp.Database.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceWebApp.Bussiness.Services
{
    public interface ICategoryService
    {
        List<Category> GetList();
    }


}
