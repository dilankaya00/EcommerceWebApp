using EcommerceWebApp.Database.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceWebApp.Database.Data
{
    public class Context : DbContext
    {
       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LENOVO;database=BookWebAppDb;integrated security=true;");
        }
        

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }




    }
}
