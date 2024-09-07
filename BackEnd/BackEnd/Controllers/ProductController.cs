using JSCdata;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace BackEnd.Controllers
{
    [Route("api/products")]
    public class ProductController : Controller
    {
        private IProductService _productService;
        public ProductController(IProductService productService) { 
            _productService = productService;
        }

        [HttpGet]
        [Route("getProducts")]
        public IActionResult getProducts()
        {
            try
            {
                return Ok(_productService.getProducts());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("addProduct")]
        public IActionResult addProduct(Product product) {
            try
            {
                return Ok(_productService.addProduct(product));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
