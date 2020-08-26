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
    public class ProductTypeFinishedFormatController : ControllerBase
    {
        private readonly DataContext _context;

        public ProductTypeFinishedFormatController(DataContext context)
        {
            _context = context;
        }

        //http://localhost:55928/api/productTypeFinishedFormat
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductTypeFinishedFormat>>> GetproductTypeFinishedFormat()
        {
            return await _context.productTypeFinishedFormat.ToListAsync();
        }

        //http://localhost:55928/api/productTypeFinishedFormat/getProFinishedFormatById?finishedFormatId=
        [HttpGet]
        [Route("getProFinishedFormatById")]
        public async Task<ActionResult<IEnumerable<ProductTypeFinishedFormat>>> getProFinishedFormatById(int finishedFormatId)
        {
            return await _context.productTypeFinishedFormat.FromSqlInterpolated($"CALL getProFinishedFormatById({finishedFormatId})").ToListAsync();
        }

        //http://localhost:55928/api/productTypeFinishedFormat?id=
        [HttpPut]
        public async Task<IActionResult> PutProductTypeFinishedFormat(int id, ProductTypeFinishedFormat productTypeFinishedFormat)
        {
            if (id != productTypeFinishedFormat.ProductTypeFinishedFormatId)
            {
                return BadRequest();
            }

            _context.Entry(productTypeFinishedFormat).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductTypeFinishedFormatExists(id))
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

        //http://localhost:55928/api/productTypeFinishedFormat
        [HttpPost]
        public async Task<ActionResult<ProductTypeFinishedFormat>> PostProductTypeFinishedFormat(ProductTypeFinishedFormat productTypeFinishedFormat)
        {
            _context.productTypeFinishedFormat.Add(productTypeFinishedFormat);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProductTypeFinishedFormat", new { id = productTypeFinishedFormat.ProductTypeFinishedFormatId }, productTypeFinishedFormat);
        }

        //http://localhost:55928/api/productTypeFinishedFormat?id=
        [HttpDelete]
        public async Task<ActionResult<ProductTypeFinishedFormat>> DeleteProductTypeFinishedFormat(int id)
        {
            var productTypeFinishedFormat = await _context.productTypeFinishedFormat.FindAsync(id);
            if (productTypeFinishedFormat == null)
            {
                return NotFound();
            }

            _context.productTypeFinishedFormat.Remove(productTypeFinishedFormat);
            await _context.SaveChangesAsync();

            return productTypeFinishedFormat;
        }

        private bool ProductTypeFinishedFormatExists(int id)
        {
            return _context.productTypeFinishedFormat.Any(e => e.ProductTypeFinishedFormatId == id);
        }
    }
}
