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
    public class RefinementController : ControllerBase
    {
        private readonly DataContext _context;

        public RefinementController(DataContext context)
        {
            _context = context;
        }

        //http://localhost:55928/api/refinement
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Refinement>>> Getrefinement()
        {
            return await _context.refinement.ToListAsync();
        }

        //http://localhost:55928/api/refinement/getRefinementById?refinementId=
        [HttpGet]
        [Route("getRefinementById")]
        public async Task<ActionResult<IEnumerable<Refinement>>> getRefinementById(int refinementId)
        {
            return await _context.refinement.FromSqlInterpolated($"CALL getRefinementById({refinementId})").ToListAsync();
        }

        //http://localhost:55928/api/refinement?id=
        [HttpPut]
        public async Task<IActionResult> PutRefinement(int id, Refinement refinement)
        {
            if (id != refinement.RefinementId)
            {
                return BadRequest();
            }

            _context.Entry(refinement).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RefinementExists(id))
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

        //http://localhost:55928/api/refinement
        [HttpPost]
        public async Task<ActionResult<Refinement>> PostRefinement(Refinement refinement)
        {
            _context.refinement.Add(refinement);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRefinement", new { id = refinement.RefinementId }, refinement);
        }

        //http://localhost:55928/api/refinement?id=
        [HttpDelete]
        public async Task<ActionResult<Refinement>> DeleteRefinement(int id)
        {
            var refinement = await _context.refinement.FindAsync(id);
            if (refinement == null)
            {
                return NotFound();
            }

            _context.refinement.Remove(refinement);
            await _context.SaveChangesAsync();

            return refinement;
        }

        private bool RefinementExists(int id)
        {
            return _context.refinement.Any(e => e.RefinementId == id);
        }
    }
}
