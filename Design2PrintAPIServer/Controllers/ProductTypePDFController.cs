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
    public class ProductTypePDFController : ControllerBase
    {
        private readonly DataContext _context;

        public ProductTypePDFController(DataContext context)
        {
            _context = context;
        }

        //http://localhost:55928/api/productTypePDF
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductTypePDF>>> GetproductTypePDF()
        {
            return await _context.productTypePDF.ToListAsync();
        }

        //http://localhost:55928/api/productTypePDF/getProPDFById?pdfId=
        [HttpGet]
        [Route("getProPDFById")]
        public async Task<ActionResult<IEnumerable<ProductTypePDF>>> getProPDFById(int pdfId)
        {
            return await _context.productTypePDF.FromSqlInterpolated($"CALL getProPDFById({pdfId})").ToListAsync();
        }

        //http://localhost:55928/api/productTypePDF?id=
        [HttpPut]
        public async Task<IActionResult> PutProductTypePDF(int id, ProductTypePDF productTypePDF)
        {
            if (id != productTypePDF.ProductTypePDFId)
            {
                return BadRequest();
            }

            _context.Entry(productTypePDF).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductTypePDFExists(id))
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

        //http://localhost:55928/api/productTypePDF
        [HttpPost]
        public async Task<ActionResult<ProductTypePDF>> PostProductTypePDF(ProductTypePDF productTypePDF)
        {
            _context.productTypePDF.Add(productTypePDF);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProductTypePDF", new { id = productTypePDF.ProductTypePDFId }, productTypePDF);
        }

        //http://localhost:55928/api/productTypePDF?id=
        [HttpDelete]
        public async Task<ActionResult<ProductTypePDF>> DeleteProductTypePDF(int id)
        {
            var productTypePDF = await _context.productTypePDF.FindAsync(id);
            if (productTypePDF == null)
            {
                return NotFound();
            }

            _context.productTypePDF.Remove(productTypePDF);
            await _context.SaveChangesAsync();

            return productTypePDF;
        }

        private bool ProductTypePDFExists(int id)
        {
            return _context.productTypePDF.Any(e => e.ProductTypePDFId == id);
        }
    }
}
