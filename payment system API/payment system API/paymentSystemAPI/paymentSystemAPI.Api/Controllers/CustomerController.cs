using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using paymentSystemAPI.Application.DTOs;
using paymentSystemAPI.Application.Interfaces.IServices;

namespace paymentSystemAPI.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        private readonly ILogger<CustomerController> _logger;
        public CustomerController(ICustomerService customerService, ILogger<CustomerController> logger)
        {
            _customerService = customerService;
            _logger = logger;
        }

        [HttpPost("addCustomer")]
        public async Task<IActionResult> AddCustomer([FromBody] CustomerDTO customerdto)
        {
            try
            {
                if(customerdto == null)
                {
                    return BadRequest("Invalid customer data");
                }

                await _customerService.AddCustomerAsync(customerdto);
                return Ok("Customer added successfully");
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error adding customer { ex.Message}");
                return StatusCode(500, "Inter server error");   
            }
        }

        [HttpGet("get-all")]
        public async Task<IActionResult> GetAllCustomers()
        {
            try
            {
                var customers = await _customerService.GetAllCustomerAsync();
                if (customers != null)
                {
                    return Ok(customers);
                }
                return NotFound("Failed to fetch customers");
               
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error getting customer {ex.Message}");
                return StatusCode(500, "Inter server error");
            }
        }
    }
}
