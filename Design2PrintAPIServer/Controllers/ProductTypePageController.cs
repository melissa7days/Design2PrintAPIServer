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
    public class ProductTypePageController : ControllerBase
    {
        private readonly DataContext _context;

        public ProductTypePageController(DataContext context)
        {
            _context = context;
        }

        //http://localhost:55928/api/productTypePage
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductTypePage>>> GetproductTypePages()
        {
            return await _context.productTypePages.ToListAsync();
        }

        //http://localhost:55928/api/productTypePage/getProPagesById?pageId=
        [HttpGet]
        [Route("getProPagesById")]
        public async Task<ActionResult<IEnumerable<ProductTypePage>>> getProPagesById(int pageId)
        {
            return await _context.productTypePages.FromSqlInterpolated($"CALL getProPagesById({pageId})").ToListAsync();
        }

        //http://localhost:55928/api/productTypePage?id=
        [HttpPut]
        public async Task<IActionResult> PutProductTypePage(int id, ProductTypePage productTypePage)
        {
            if (id != productTypePage.ProductTypePageId)
            {
                return BadRequest();
            }

            _context.Entry(productTypePage).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductTypePageExists(id))
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

        //http://localhost:55928/api/productTypePage
        [HttpPost]
        public async Task<ActionResult<ProductTypePage>> PostProductTypePage(ProductTypePage productTypePage)
        {
            _context.productTypePages.Add(productTypePage);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProductTypePage", new { id = productTypePage.ProductTypePageId }, productTypePage);
        }

        //http://localhost:55928/api/productTypePage?id=
        [HttpDelete]
        public async Task<ActionResult<ProductTypePage>> DeleteProductTypePage(int id)
        {
            var productTypePage = await _context.productTypePages.FindAsync(id);
            if (productTypePage == null)
            {
                return NotFound();
            }

            _context.productTypePages.Remove(productTypePage);
            await _context.SaveChangesAsync();

            return productTypePage;
        }

        private bool ProductTypePageExists(int id)
        {
            return _context.productTypePages.Any(e => e.ProductTypePageId == id);
        }
    }
}
