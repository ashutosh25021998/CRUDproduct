using CRUDWebApiWithSwagger.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiWithSwagger.Models;

namespace WebApiWithSwagger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductContext _context;
        public ProductController(ProductContext context)
        {
            this._context = context;
        }


        // GET: api/Product(gettig All Product)
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDetails>>> GetProduct()
        {
            return await _context.ProductDetails.ToListAsync();
        }


        // GET: api/Product/5(Getting Product Details by the id)
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDetails>> GetProductById(int id)
        {
            var product = await _context.ProductDetails.FindAsync(id);

            if (product == null)
            {
                throw new Exception("There is no product available on this Id. ");
            }

            return product;
        }



        // POST: api/Product(Add new Product data)
        [HttpPost]
        public async Task<ActionResult<ProductDetails>> AddProduct(ProductDetails productDetails)
        {
            _context.ProductDetails.Add(productDetails);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProduct", new { id = productDetails.ProductId }, productDetails);
        }



        // PUT: api/ProductItems/5(Update a Product Details)
        [HttpPut]
        public async Task<IActionResult> UpdateProduct([FromBody] ProductDetails productDetails)
        {

            _context.Entry(productDetails).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                return BadRequest();
            }

            return CreatedAtAction("GetProduct", new { id = productDetails.ProductId }, productDetails);
        }



        // DELETE: api/Product/5(Delete a product)
        [HttpDelete("{id}")]
        public async Task<ActionResult<ProductDetails>> DeleteProduct(int id)
        {
            var product = await _context.ProductDetails.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            _context.ProductDetails.Remove(product);
            await _context.SaveChangesAsync();

            return product;
        }
    }
}