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
    public class FinishingController : ControllerBase
    {
        private readonly DataContext _context;

        public FinishingController(DataContext context)
        {
            _context = context;
        }

        //http://localhost:55928/api/finishing
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Finishing>>> Getfinishing()
        {
            return await _context.finishing.ToListAsync();
        }

        //http://localhost:55928/api/finishing/getFinishingById?finishingId=
        [HttpGet]
        [Route("getFinishingById")]
        public async Task<ActionResult<IEnumerable<Finishing>>> getFinishingById(int finishingId)
        {
            return await _context.finishing.FromSqlInterpolated($"CALL getFinishingById({finishingId})").ToListAsync();
        }

        //http://localhost:55928/api/finishing?id=
        [HttpPut]
        public async Task<IActionResult> PutFinishing(int id, Finishing finishing)
        {
            if (id != finishing.FinishingId)
            {
                return BadRequest();
            }

            _context.Entry(finishing).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FinishingExists(id))
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

        //http://localhost:55928/api/finishing
        [HttpPost]
        public async Task<ActionResult<Finishing>> PostFinishing(Finishing finishing)
        {
            _context.finishing.Add(finishing);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFinishing", new { id = finishing.FinishingId }, finishing);
        }

        //http://localhost:55928/api/finishing?id=
        [HttpDelete]
        public async Task<ActionResult<Finishing>> DeleteFinishing(int id)
        {
            var finishing = await _context.finishing.FindAsync(id);
            if (finishing == null)
            {
                return NotFound();
            }

            _context.finishing.Remove(finishing);
            await _context.SaveChangesAsync();

            return finishing;
        }

        private bool FinishingExists(int id)
        {
            return _context.finishing.Any(e => e.FinishingId == id);
        }
    }
}
