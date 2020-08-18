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
    public class ProductTypeController : ControllerBase
    {
        private readonly DataContext _context;

        public ProductTypeController(DataContext context)
        {
            _context = context;
        }

        //http://localhost:55928/api/producttype
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductType>>> GetproductType()
        {
            return await _context.productType.ToListAsync();
        }

        //http://localhost:55928/api/producttype/getProductTypeById?productTypeId=
        [HttpGet]
        [Route("getProductTypeById")]
        public async Task<ActionResult<IEnumerable<ProductType>>> getCategoryById(int productTypeId)
        {
            return await _context.productType.FromSqlInterpolated($"CALL getProductTypeById({productTypeId})").ToListAsync();
        }

        //http://localhost:55928/api/producttype?id=
        [HttpPut]
        public async Task<IActionResult> PutProductType(int id, ProductType productType)
        {
            if (id != productType.ProductTypeId)
            {
                return BadRequest();
            }

            _context.Entry(productType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductTypeExists(id))
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

        //http://localhost:55928/api/producttype
        [HttpPost]
        public async Task<ActionResult<ProductType>> PostProductType(ProductType productType)
        {
            _context.productType.Add(productType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProductType", new { id = productType.ProductTypeId }, productType);
        }

        //http://localhost:55928/api/producttype?id=
        [HttpDelete]
        public async Task<ActionResult<ProductType>> DeleteProductType(int id)
        {
            var productType = await _context.productType.FindAsync(id);
            if (productType == null)
            {
                return NotFound();
            }

            _context.productType.Remove(productType);
            await _context.SaveChangesAsync();

            return productType;
        }

        private bool ProductTypeExists(int id)
        {
            return _context.productType.Any(e => e.ProductTypeId == id);
        }
    }
}
