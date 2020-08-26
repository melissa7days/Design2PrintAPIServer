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
    public class ProductTypeOptionController : ControllerBase
    {
        private readonly DataContext _context;

        public ProductTypeOptionController(DataContext context)
        {
            _context = context;
        }

        //http://localhost:55928/api/productTypeOption
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductTypeOption>>> GetproductTypeOption()
        {
            return await _context.productTypeOption.ToListAsync();
        }

        //http://localhost:55928/api/productTypeOption/getProOptionsById?optionId=
        [HttpGet]
        [Route("getProOptionsById")]
        public async Task<ActionResult<IEnumerable<ProductTypeOption>>> getProOptionsById(int optionId)
        {
            return await _context.productTypeOption.FromSqlInterpolated($"CALL getProOptionsById({optionId})").ToListAsync();
        }

        //http://localhost:55928/api/productTypeOption?id=
        [HttpPut]
        public async Task<IActionResult> PutProductTypeOption(int id, ProductTypeOption productTypeOption)
        {
            if (id != productTypeOption.ProductTypeOptionId)
            {
                return BadRequest();
            }

            _context.Entry(productTypeOption).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductTypeOptionExists(id))
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

        //http://localhost:55928/api/productTypeOption
        [HttpPost]
        public async Task<ActionResult<ProductTypeOption>> PostProductTypeOption(ProductTypeOption productTypeOption)
        {
            _context.productTypeOption.Add(productTypeOption);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProductTypeOption", new { id = productTypeOption.ProductTypeOptionId }, productTypeOption);
        }

        //http://localhost:55928/api/productTypeOption?id=
        [HttpDelete]
        public async Task<ActionResult<ProductTypeOption>> DeleteProductTypeOption(int id)
        {
            var productTypeOption = await _context.productTypeOption.FindAsync(id);
            if (productTypeOption == null)
            {
                return NotFound();
            }

            _context.productTypeOption.Remove(productTypeOption);
            await _context.SaveChangesAsync();

            return productTypeOption;
        }

        private bool ProductTypeOptionExists(int id)
        {
            return _context.productTypeOption.Any(e => e.ProductTypeOptionId == id);
        }
    }
}
