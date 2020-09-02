using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Design2PrintAPIServer.Data;
using Design2PrintAPIServer.Models;

namespace Design2PrintAPIServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly DataContext _context;

        public ProductController(DataContext context)
        {
            _context = context;
        }

        //http://localhost:55928/api/product
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> Getproduct()
        {
            return await _context.product.ToListAsync();
        }

        //http://localhost:55928/api/product/getAllProducts
        [HttpGet]
        [Route("getAllProducts")]
        public async Task<ActionResult<IEnumerable<ProductViewModel>>> getAllProducts()
        {
            return await _context.productViewModel.FromSqlInterpolated($"CALL getAllProducts").ToListAsync();
        }

        //http://localhost:55928/api/product/getProductsById?productId=
        [HttpGet]
        [Route("getProductsById")]
        public async Task<ActionResult<IEnumerable<ProductByIdViewModel>>> getProductsById(int productId)
        {
            return await _context.productByIdViewModel.FromSqlInterpolated($"CALL getProductsById({productId})").ToListAsync();
        }

        //http://localhost:55928/api/product?id=
        [HttpPut]
        public async Task<IActionResult> PutProduct(int id, Product product)
        {
            if (id != product.ProductId)
            {
                return BadRequest();
            }

            _context.Entry(product).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        //http://localhost:55928/api/product
        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct(Product product)
        {
            _context.product.Add(product);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProduct", new { id = product.ProductId }, product);
        }

        //http://localhost:55928/api/product?id=
        [HttpDelete]
        public async Task<ActionResult<Product>> DeleteProduct(int id)
        {
            var product = await _context.product.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            _context.product.Remove(product);
            await _context.SaveChangesAsync();

            return product;
        }

        private bool ProductExists(int id)
        {
            return _context.product.Any(e => e.ProductId == id);
        }
    }
}
