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
    public class QuantityController : ControllerBase
    {
        private readonly DataContext _context;

        public QuantityController(DataContext context)
        {
            _context = context;
        }

        //http://localhost:55928/api/quantity
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Quantity>>> Getquantity()
        {
            return await _context.quantity.ToListAsync();
        }

        //http://localhost:55928/api/quantity/getQuantityById?quantityId=
        [HttpGet]
        [Route("getQuantityById")]
        public async Task<ActionResult<IEnumerable<Quantity>>> getQuantityById(int quantityId)
        {
            return await _context.quantity.FromSqlInterpolated($"CALL getQuantityById({quantityId})").ToListAsync();
        }

        //http://localhost:55928/api/quantity?id=
        [HttpPut]
        public async Task<IActionResult> PutQuantity(int id, Quantity quantity)
        {
            if (id != quantity.QuantityId)
            {
                return BadRequest();
            }

            _context.Entry(quantity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!QuantityExists(id))
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

        //http://localhost:55928/api/quantity
        [HttpPost]
        public async Task<ActionResult<Quantity>> PostQuantity(Quantity quantity)
        {
            _context.quantity.Add(quantity);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetQuantity", new { id = quantity.QuantityId }, quantity);
        }

        //http://localhost:55928/api/quantity?id=
        [HttpDelete]
        public async Task<ActionResult<Quantity>> DeleteQuantity(int id)
        {
            var quantity = await _context.quantity.FindAsync(id);
            if (quantity == null)
            {
                return NotFound();
            }

            _context.quantity.Remove(quantity);
            await _context.SaveChangesAsync();

            return quantity;
        }

        private bool QuantityExists(int id)
        {
            return _context.quantity.Any(e => e.QuantityId == id);
        }
    }
}
