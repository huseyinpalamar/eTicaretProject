using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {

        ICustomerService _customerSrvice;

        public CustomersController(ICustomerService customerService)
        {
            _customerSrvice=customerService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result= _customerSrvice.GetAll();
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result.Message);
        }
        [HttpGet("getybyid")]

        public IActionResult GetById(string id)
        {
            var result=_customerSrvice.GetById(id);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result.Message);
        }
        [HttpPost("add")]
        public IActionResult Add(Customer customer)
        {
            var result = _customerSrvice.Add(customer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Customer customer)
        {
            var result = _customerSrvice.Delete(customer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpPost("update")]
        public IActionResult Update(Customer customer)
        {
            var result = _customerSrvice.Update(customer); 
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
    }
}
