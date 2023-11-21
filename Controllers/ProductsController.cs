using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lab_sqli.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace lab_sqli.Controllers
{
    [ApiController]
    [Route("product")]
    public class ProductsController : ControllerBase
    {

        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProduct([FromQuery] string search)
        {
            return Ok(await _productService.GetAllProductSearch(search));
        }
    }
}