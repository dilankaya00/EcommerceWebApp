using EcommerceWebApp.Bussiness.Model;
using EcommerceWebApp.Database.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcommerceWebApp.Core.Results;

namespace EcommerceWebApp.Bussiness.Services
{
    public interface IProductService /*: IBaseService<ProductModel, Product>*/
    {
        Product GetAllAsnyc(int Id);
        List<ProductModel> GetProductListByCategoryId(int categoryId);
       // List<ProductModel> GetProductList(ProductListRequestModel model);
    }
}
