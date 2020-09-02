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
    public class ProductTypeColorController : ControllerBase
    {
        private readonly DataContext _context;

        public ProductTypeColorController(DataContext context)
        {
            _context = context;
        }

        //http://localhost:55928/api/productTypeColor
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductTypeColor>>> GetproductTypeColor()
        {
            return await _context.productTypeColor.ToListAsync();
        }

        //http://localhost:55928/api/productTypeColor/getProColorById?colorId=
        [HttpGet]
        [Route("getProColorById")]
        public async Task<ActionResult<IEnumerable<ProductTypeColorViewModel>>> getProColorById(int colorId)
        {
            return await _context.productTypeColorViewModel.FromSqlInterpolated($"CALL getProColorById({colorId})").ToListAsync();
        }

        //http://localhost:55928/api/productTypeColor?id=
        [HttpPut]
        public async Task<IActionResult> PutProductTypeColor(int id, ProductTypeColor productTypeColor)
        {
            if (id != productTypeColor.ProductTypeColorId)
            {
                return BadRequest();
            }

            _context.Entry(productTypeColor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductTypeColorExists(id))
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

        //http://localhost:55928/api/productTypeColor
        [HttpPost]
        public async Task<ActionResult<ProductTypeColor>> PostProductTypeColor(ProductTypeColor productTypeColor)
        {
            _context.productTypeColor.Add(productTypeColor);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProductTypeColor", new { id = productTypeColor.ProductTypeColorId }, productTypeColor);
        }

        //http://localhost:55928/api/productTypeColor?id=
        [HttpDelete]
        public async Task<ActionResult<ProductTypeColor>> DeleteProductTypeColor(int id)
        {
            var productTypeColor = await _context.productTypeColor.FindAsync(id);
            if (productTypeColor == null)
            {
                return NotFound();
            }

            _context.productTypeColor.Remove(productTypeColor);
            await _context.SaveChangesAsync();

            return productTypeColor;
        }

        private bool ProductTypeColorExists(int id)
        {
            return _context.productTypeColor.Any(e => e.ProductTypeColorId == id);
        }
    }
}
