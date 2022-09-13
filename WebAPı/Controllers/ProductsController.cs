using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")] 
    [ApiController]//ATTRIBUTE
    public class ProductsController : ControllerBase
    {
        //Loosely coupled -- gevşek bağımlılık.
        IProductService _productService; // (_blabla)naming convention

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("getall")]
        public IActionResult  GetAll()
        {
            var result = _productService.GetAll();
            if (result.Success)
            {
                return Ok(result);
                
            }
            return BadRequest(result.Message);
            

        }

        [HttpPost("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _productService.GetById( id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("getallbyunitprice")]
        public IActionResult GetAllByUnitPrice(decimal min, decimal max)
        {
            var result = _productService.GetAllByUnitPrice(min, max);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("getallbycategoryid")]
        public IActionResult GetAllByCategoryId(int categoryId)
        {
            var result = _productService.GetAllByCategoryId(categoryId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("getproductdetaildto")]

        public IActionResult GetProductDetailDto()
        {

            var result = _productService.GetProductDetail();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Success);
        }

        [HttpPost("add")]
        public IActionResult Add(Product product)
        {
            var result =_productService.Add(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Product product)
        {
            var result = _productService.Delete(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpPost("update")]
        public IActionResult Update(Product product)
        {
            var result = _productService.Update(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

    }
}
