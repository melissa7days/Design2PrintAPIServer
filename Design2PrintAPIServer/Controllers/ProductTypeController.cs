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

        // GET: api/ProductType
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductType>>> GetproductType()
        {
            return await _context.productType.ToListAsync();
        }

        // GET: api/ProductType/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductType>> GetProductType(int id)
        {
            var productType = await _context.productType.FindAsync(id);

            if (productType == null)
            {
                return NotFound();
            }

            return productType;
        }

        // PUT: api/ProductType/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
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

        // POST: api/ProductType
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ProductType>> PostProductType(ProductType productType)
        {
            _context.productType.Add(productType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProductType", new { id = productType.ProductTypeId }, productType);
        }

        // DELETE: api/ProductType/5
        [HttpDelete("{id}")]
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
