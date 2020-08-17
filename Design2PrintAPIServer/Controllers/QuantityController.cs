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

        // GET: api/Quantity
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Quantity>>> Getquantity()
        {
            return await _context.quantity.ToListAsync();
        }

        // GET: api/Quantity/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Quantity>> GetQuantity(int id)
        {
            var quantity = await _context.quantity.FindAsync(id);

            if (quantity == null)
            {
                return NotFound();
            }

            return quantity;
        }

        // PUT: api/Quantity/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
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

        // POST: api/Quantity
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Quantity>> PostQuantity(Quantity quantity)
        {
            _context.quantity.Add(quantity);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetQuantity", new { id = quantity.QuantityId }, quantity);
        }

        // DELETE: api/Quantity/5
        [HttpDelete("{id}")]
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
