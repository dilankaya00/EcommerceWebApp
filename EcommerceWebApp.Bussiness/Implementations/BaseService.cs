using AutoMapper;
using EcommerceWebApp.Bussiness.Services;
using EcommerceWebApp.Core.Entities;
using EcommerceWebApp.Core.Repository;
using EcommerceWebApp.Core.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace EcommerceWebApp.Bussiness.Implementations
{
    public class BaseService<TModel, TEntity> : IBaseService<TModel, TEntity>
       where TModel : BaseModel
       where TEntity : BaseEntity
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<TEntity> _repository;
        private readonly IMapper _mapper;
        public BaseService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _repository = _unitOfWork.GetRepository<TEntity>();
            _mapper = mapper;
        }

        public void Add(TModel model)
        {
            try
            {
                _repository.Add(_mapper.Map<TEntity>(model));
                _unitOfWork.SaveChanges();
                
            }
            catch (Exception ex)
            {
                
            }
        }

        public void Delete(TModel model)
        {
            try
            {
                _repository.Delete(_mapper.Map<TEntity>(model));
                _unitOfWork.SaveChanges();
                
            }
            catch (Exception ex)
            {

            }
        }

        public void DeleteById(int id)
        {
            try
            {
                _repository.Delete(id);
                _unitOfWork.SaveChanges();
               
            }
            catch (Exception ex)
            {

               
            }
        }

        public List<TModel> GetAll()
        {
            try
            {
                var entities = _repository.GetAll().Select(x => _mapper.Map<TModel>(x)).ToList();
                return entities;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public TModel GetById(int id)
        {
            try
            {
                var result = _mapper.Map<TEntity, TModel>(_repository.GetById(id));
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public void Update(TModel model)
        {
            try
            {
                _repository.Update(_mapper.Map<TEntity>(model));
                _unitOfWork.SaveChanges();
               
            }
            catch (Exception ex)
            {
                
            }

        }
    }
}