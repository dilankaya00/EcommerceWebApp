using EcommerceWebApp.Bussiness.Infrastructure;
using EcommerceWebApp.Bussiness.Model;
using EcommerceWebApp.Bussiness.Services;
using EcommerceWebApp.Core.UnitOfWork;
using EcommerceWebApp.Database.Data;
using EcommerceWebApp.Database.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceWebApp.Bussiness.Implementations
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork; 
        private readonly Context _context; 
        public ProductService(Context context,IUnitOfWork unitOfWork)
        {
            _context = context;
            _unitOfWork = unitOfWork;

        }
        public Product GetAllAsnyc(int Id)
        {
            var list = _context.Products.Find(Id);
            _unitOfWork.SaveChanges();
            return list;
        }

        public List<ProductModel> GetProductListByCategoryId(int categoryId)
        {
            throw new NotImplementedException();
        }
    }
}
