using EcommerceWebApp.Bussiness.Services;
using EcommerceWebApp.Core.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceWebApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseController<TModel, TEntity> : Controller
        where TModel : BaseModel
        where TEntity : BaseEntity
    {
        private readonly IBaseService<TModel, TEntity> _baseService;
        public BaseController(IBaseService<TModel, TEntity> baseService)
        {
            _baseService = baseService;
        }

        public BaseController(ICategoryService categoryService)
        {
        }

        [HttpGet("GetAll")]
        public virtual IActionResult GetAll()
        {
            var result = _baseService.GetAll();

            //if (result.Success == true)
            //{
            //    return Ok(result);
            //}
            //else
            //{
            //    return BadRequest(result.Message);
            //}
            return null;
        }

        [HttpGet("GetById")]
        public virtual IActionResult GetById(int id)
        {
            var result = _baseService.GetById(id);

            //if (result.Success == true)
            //{
            //    return Ok(result);
            //}
            //else
            //{
            //    return BadRequest(result.Message);
            //}
            return null;
        }
        [Authorize(Roles = "admin")]
        [HttpPost("Add")]
        public virtual IActionResult Add([FromBody] TModel model)
        {
            //var result = _baseService.Add(model);
            //if (result.Success == true)
            //{
            //    return Ok(result);
            //}
            //else
            //{
            //    return BadRequest(result.Message);
            //}

            return null;


        }

        [HttpPost("Update")]
        public virtual IActionResult Update([FromBody] TModel model)
        {
            //var result = _baseService.Update(model);
            //if (result.Success == true)
            //{
            //    return Ok(result);
            //}
            //else
            //{
            //    return BadRequest(result.Message);
            //}

            return null;

        }

        [HttpPost("Delete")]
        public virtual IActionResult Delete([FromBody] TModel model)
        {
            //var result = _baseService.Delete(model);
            //if (result.Success == true)
            //{
            //    return Ok(result);
            //}
            //else
            //{
            //    return BadRequest(result.Message);
            //}

            return null;

        }

        [HttpPost("DeleteById")]
        public virtual IActionResult DeleteById(int id)
        {
            //var result = _baseService.DeleteById(id);
            //if (result.Success == true)
            //{
            //    return Ok(result);
            //}
            //else
            //{
            //    return BadRequest(result.Message);
            //}
            return null;
        }
    }
}
