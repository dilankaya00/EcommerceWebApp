using EcommerceWebApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceWebApp.Bussiness.Services
{
    public interface IBaseService<TModel,TEntity> where TModel : BaseModel where TEntity:BaseEntity
        {
        List<TModel> GetAll();
        TModel GetById(int id);
        void Add(TModel model);
        void Update(TModel model);
        void Delete(TModel model);
        void DeleteById(int id);

    }
}
