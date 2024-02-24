using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using AuthenticatedAPI.Common.Models;
using AuthenticatedAPI.Common.Data;

namespace AuthenticatedAPI.Controllers 
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ApplicationDataContext _context; 
        public ProductController(ApplicationDataContext context) 
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var products = _context.Products.ToList();
            return Ok(products);
        }

        [HttpGet("{categoryId}")]
        public IActionResult GetByCategoryId(int categoryId)
        {
            var productsInCategory = _context.Products
            .Where(p => p.CategoryId == categoryId)
            .ToList();

            if(productsInCategory == null || !productsInCategory.Any())
            {
                return NotFound("No products found");
            }

            return Ok(productsInCategory);
        }

        [HttpPost]
        public IActionResult AddProduct([FromBody] ProductModel product)
        {
            if(product == null)
            {
                return BadRequest("Product data is missing");
            }

            _context.Products.Add(product);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetById), new { id = product.Id }, product);
        }
    }
}
