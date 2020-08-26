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
    public class ProductTypeBookBindingController : ControllerBase
    {
        private readonly DataContext _context;

        public ProductTypeBookBindingController(DataContext context)
        {
            _context = context;
        }

        //http://localhost:55928/api/productTypeBookBinding
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductTypeBookBinding>>> GetproductTypeBookBinding()
        {
            return await _context.productTypeBookBinding.ToListAsync();
        }

        //http://localhost:55928/api/productTypeBookBinding/getProBookBindingById?bookBindingId=
        [HttpGet]
        [Route("getProBookBindingById")]
        public async Task<ActionResult<IEnumerable<ProductTypeBookBinding>>> getProBookBindingById(int bookBindingId)
        {
            return await _context.productTypeBookBinding.FromSqlInterpolated($"CALL getProBookBindingById({bookBindingId})").ToListAsync();
        }

        //http://localhost:55928/api/productTypeBookBinding?id=
        [HttpPut]
        public async Task<IActionResult> PutProductTypeBookBinding(int id, ProductTypeBookBinding productTypeBookBinding)
        {
            if (id != productTypeBookBinding.ProductTypeBookBindingId)
            {
                return BadRequest();
            }

            _context.Entry(productTypeBookBinding).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductTypeBookBindingExists(id))
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

        //http://localhost:55928/api/productTypeBookBinding
        [HttpPost]
        public async Task<ActionResult<ProductTypeBookBinding>> PostProductTypeBookBinding(ProductTypeBookBinding productTypeBookBinding)
        {
            _context.productTypeBookBinding.Add(productTypeBookBinding);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProductTypeBookBinding", new { id = productTypeBookBinding.ProductTypeBookBindingId }, productTypeBookBinding);
        }

        //http://localhost:55928/api/productTypeBookBinding?id=
        [HttpDelete]
        public async Task<ActionResult<ProductTypeBookBinding>> DeleteProductTypeBookBinding(int id)
        {
            var productTypeBookBinding = await _context.productTypeBookBinding.FindAsync(id);
            if (productTypeBookBinding == null)
            {
                return NotFound();
            }

            _context.productTypeBookBinding.Remove(productTypeBookBinding);
            await _context.SaveChangesAsync();

            return productTypeBookBinding;
        }

        private bool ProductTypeBookBindingExists(int id)
        {
            return _context.productTypeBookBinding.Any(e => e.ProductTypeBookBindingId == id);
        }
    }
}
