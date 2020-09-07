using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Design2PrintAPIServer.Data;
using Design2PrintAPIServer.Models;
using Design2PrintAPIServer.Models.CustomModels;

namespace Design2PrintAPIServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductTypeQuantityController : ControllerBase
    {
        private readonly DataContext _context;

        public ProductTypeQuantityController(DataContext context)
        {
            _context = context;
        }

        //http://localhost:55928/api/productTypeQuantity
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductTypeQuantity>>> GetproductTypeQuantity()
        {
            return await _context.productTypeQuantity.ToListAsync();
        }

        //http://localhost:55928/api/productTypeQuantity/getAllProductTypeQuantity
        [HttpGet]
        [Route("getAllProductTypeQuantity")]
        public async Task<ActionResult<IEnumerable<ProductTypeQuantityViewModel>>> getAllProductTypeQuantity()
        {
            return await _context.productTypeQuantityViewModel.FromSqlInterpolated($"CALL getAllProductTypeQuantity").ToListAsync();
        }

        //http://localhost:55928/api/productTypeQuantity/getProQuantityById?productTypeQuantityId=
        [HttpGet]
        [Route("getProQuantityById")]
        public async Task<ActionResult<IEnumerable<ProductTypeQuantityViewModel>>> getProQuantityById(int productTypeQuantityId)
        {
            return await _context.productTypeQuantityViewModel.FromSqlInterpolated($"CALL getProQuantityById({productTypeQuantityId})").ToListAsync();
        }

        //http://localhost:55928/api/productTypeQuantity?id=
        [HttpPut]
        public async Task<IActionResult> PutProductTypeQuantity(int id, ProductTypeQuantity productTypeQuantity)
        {
            if (id != productTypeQuantity.ProductTypeQuantityId)
            {
                return BadRequest();
            }

            _context.Entry(productTypeQuantity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductTypeQuantityExists(id))
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

        //http://localhost:55928/api/productTypeQuantity
        [HttpPost]
        public async Task<ActionResult<ProductTypeQuantity>> PostProductTypeQuantity(ProductTypeQuantity productTypeQuantity)
        {
            _context.productTypeQuantity.Add(productTypeQuantity);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProductTypeQuantity", new { id = productTypeQuantity.ProductTypeQuantityId }, productTypeQuantity);
        }

        //http://localhost:55928/api/productTypeQuantity?id=
        [HttpDelete]
        public async Task<ActionResult<ProductTypeQuantity>> DeleteProductTypeQuantity(int id)
        {
            var productTypeQuantity = await _context.productTypeQuantity.FindAsync(id);
            if (productTypeQuantity == null)
            {
                return NotFound();
            }

            _context.productTypeQuantity.Remove(productTypeQuantity);
            await _context.SaveChangesAsync();

            return productTypeQuantity;
        }

        private bool ProductTypeQuantityExists(int id)
        {
            return _context.productTypeQuantity.Any(e => e.ProductTypeQuantityId == id);
        }
    }
}
