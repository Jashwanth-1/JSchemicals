using JSCdata;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace BackEnd.Controllers
{
    [Route("api/customers")]
    public class CustomerController : Controller
    {
        private ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        [Route("getCustomers")]
        public IActionResult getCustomers()
        {
            try
            {
                return Ok(_customerService.getCustomers());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("addCustomer")]
        public IActionResult addCustomer(Customer customer)
        {
            try
            {
                return Ok(_customerService.addCustomer(customer));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
