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
    public class ProductTypeDiscountController : ControllerBase
    {
        private readonly DataContext _context;

        public ProductTypeDiscountController(DataContext context)
        {
            _context = context;
        }

        //http://localhost:55928/api/productTypeDiscount
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductTypeDiscount>>> GetproductTypeDiscount()
        {
            return await _context.productTypeDiscount.ToListAsync();
        }

        //http://localhost:55928/api/productTypeDiscount/getProDiscountById?discountId=
        [HttpGet]
        [Route("getProDiscountById")]
        public async Task<ActionResult<IEnumerable<ProductTypeDiscountViewModel>>> getProDiscountById(int discountId)
        {
            return await _context.productTypeDiscountViewModels.FromSqlInterpolated($"CALL getProDiscountById({discountId})").ToListAsync();
        }

        //http://localhost:55928/api/productTypeDiscount?id=
        [HttpPut]
        public async Task<IActionResult> PutProductTypeDiscount(int id, ProductTypeDiscount productTypeDiscount)
        {
            if (id != productTypeDiscount.ProductTypeDiscountId)
            {
                return BadRequest();
            }

            _context.Entry(productTypeDiscount).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductTypeDiscountExists(id))
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

        //http://localhost:55928/api/productTypeDiscount
        [HttpPost]
        public async Task<ActionResult<ProductTypeDiscount>> PostProductTypeDiscount(ProductTypeDiscount productTypeDiscount)
        {
            _context.productTypeDiscount.Add(productTypeDiscount);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProductTypeDiscount", new { id = productTypeDiscount.ProductTypeDiscountId }, productTypeDiscount);
        }

        //http://localhost:55928/api/productTypeDiscount?id=
        [HttpDelete]
        public async Task<ActionResult<ProductTypeDiscount>> DeleteProductTypeDiscount(int id)
        {
            var productTypeDiscount = await _context.productTypeDiscount.FindAsync(id);
            if (productTypeDiscount == null)
            {
                return NotFound();
            }

            _context.productTypeDiscount.Remove(productTypeDiscount);
            await _context.SaveChangesAsync();

            return productTypeDiscount;
        }

        private bool ProductTypeDiscountExists(int id)
        {
            return _context.productTypeDiscount.Any(e => e.ProductTypeDiscountId == id);
        }
    }
}
