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
    public class DiscountController : ControllerBase
    {
        private readonly DataContext _context;

        public DiscountController(DataContext context)
        {
            _context = context;
        }

        //http://localhost:55928/api/discount
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Discount>>> Getdiscount()
        {
            return await _context.discount.ToListAsync();
        }

        //http://localhost:55928/api/discount/getDiscountById?discountId=
        [HttpGet]
        [Route("getDiscountById")]
        public async Task<ActionResult<IEnumerable<Discount>>> getDiscountById(int discountId)
        {
            return await _context.discount.FromSqlInterpolated($"CALL getDiscountById({discountId})").ToListAsync();
        }

        //http://localhost:55928/api/discount?id=
        [HttpPut]
        public async Task<IActionResult> PutDiscount(int id, Discount discount)
        {
            if (id != discount.DiscountId)
            {
                return BadRequest();
            }

            _context.Entry(discount).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DiscountExists(id))
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

        //http://localhost:55928/api/discount
        [HttpPost]
        public async Task<ActionResult<Discount>> PostDiscount(Discount discount)
        {
            _context.discount.Add(discount);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDiscount", new { id = discount.DiscountId }, discount);
        }

        //http://localhost:55928/api/discount?id=
        [HttpDelete]
        public async Task<ActionResult<Discount>> DeleteDiscount(int id)
        {
            var discount = await _context.discount.FindAsync(id);
            if (discount == null)
            {
                return NotFound();
            }

            _context.discount.Remove(discount);
            await _context.SaveChangesAsync();

            return discount;
        }

        private bool DiscountExists(int id)
        {
            return _context.discount.Any(e => e.DiscountId == id);
        }
    }
}
