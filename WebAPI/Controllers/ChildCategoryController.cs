using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChildCategoryController : ControllerBase
    {
        private IChildCategoryService _childCategoryService;
        public ChildCategoryController(IChildCategoryService childCategoryService)
        {
            _childCategoryService = childCategoryService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _childCategoryService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int childCategoryId)
        {
            var result = _childCategoryService.GetById(childCategoryId);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
        [HttpGet("getlistbysubcategory")]
        public IActionResult GetListBySubCategory(int subCategoryId)
        {
            var result = _childCategoryService.GetListBySubCategory(subCategoryId);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(ChildCategory childCategory)
        {
            var result = _childCategoryService.Add(childCategory);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(ChildCategory childCategory)
        {
            var result = _childCategoryService.Update(childCategory);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(int childCategoryId)
        {
            var result = _childCategoryService.Delete(childCategoryId);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

    }
}
