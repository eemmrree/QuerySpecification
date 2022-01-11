using Microsoft.AspNetCore.Mvc;
using QuerySpecification.Application;
using QuerySpecification.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuerySpecification.API.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult FindAllProduct()
        {
            List<ProductDto> products = _productService.GetAll();
            return View(products);
        }
       
    }

}
