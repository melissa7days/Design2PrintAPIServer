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
    public class ProductTypeFinishingController : ControllerBase
    {
        private readonly DataContext _context;

        public ProductTypeFinishingController(DataContext context)
        {
            _context = context;
        }

        //http://localhost:55928/api/productTypeFinishing
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductTypeFinishing>>> GetproductTypeFinishing()
        {
            return await _context.productTypeFinishing.ToListAsync();
        }

        //http://localhost:55928/api/productTypeFinishing/getAllProductTypeFinishings
        [HttpGet]
        [Route("getAllProductTypeFinishings")]
        public async Task<ActionResult<IEnumerable<ProductTypeFinishingViewModel>>> getAllProductTypeFinishings()
        {
            return await _context.productTypeFinishingViewModel.FromSqlInterpolated($"CALL getAllProductTypeFinishings").ToListAsync();
        }

        //http://localhost:55928/api/productTypeFinishing/getProFinishingById?productTypeFinishingId=
        [HttpGet]
        [Route("getProFinishingById")]
        public async Task<ActionResult<IEnumerable<ProductTypeFinishingViewModel>>> getProFinishingById(int productTypeFinishingId)
        {
            return await _context.productTypeFinishingViewModel.FromSqlInterpolated($"CALL getProFinishingById({productTypeFinishingId})").ToListAsync();
        }

        //http://localhost:55928/api/productTypeFinishing?id=
        [HttpPut]
        public async Task<IActionResult> PutProductTypeFinishing(int id, ProductTypeFinishing productTypeFinishing)
        {
            if (id != productTypeFinishing.ProductTypeFinishingId)
            {
                return BadRequest();
            }

            _context.Entry(productTypeFinishing).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductTypeFinishingExists(id))
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

        //http://localhost:55928/api/productTypeFinishing
        [HttpPost]
        public async Task<ActionResult<ProductTypeFinishing>> PostProductTypeFinishing(ProductTypeFinishing productTypeFinishing)
        {
            _context.productTypeFinishing.Add(productTypeFinishing);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProductTypeFinishing", new { id = productTypeFinishing.ProductTypeFinishingId }, productTypeFinishing);
        }

        //http://localhost:55928/api/productTypeFinishing?id=
        [HttpDelete]
        public async Task<ActionResult<ProductTypeFinishing>> DeleteProductTypeFinishing(int id)
        {
            var productTypeFinishing = await _context.productTypeFinishing.FindAsync(id);
            if (productTypeFinishing == null)
            {
                return NotFound();
            }

            _context.productTypeFinishing.Remove(productTypeFinishing);
            await _context.SaveChangesAsync();

            return productTypeFinishing;
        }

        private bool ProductTypeFinishingExists(int id)
        {
            return _context.productTypeFinishing.Any(e => e.ProductTypeFinishingId == id);
        }
    }
}
