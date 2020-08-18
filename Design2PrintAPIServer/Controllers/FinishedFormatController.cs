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
    public class FinishedFormatController : ControllerBase
    {
        private readonly DataContext _context;

        public FinishedFormatController(DataContext context)
        {
            _context = context;
        }

        //http://localhost:55928/api/finishedFormat
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FinishedFormat>>> GetfinishedFormat()
        {
            return await _context.finishedFormat.ToListAsync();
        }

        //http://localhost:55928/api/finishedFormat/getFinishedFormatById?finishedFormatId=
        [HttpGet]
        [Route("getFinishedFormatById")]
        public async Task<ActionResult<IEnumerable<FinishedFormat>>> getFinishedFormatById(int finishedFormatId)
        {
            return await _context.finishedFormat.FromSqlInterpolated($"CALL getFinishedFormatById({finishedFormatId})").ToListAsync();
        }

        //http://localhost:55928/api/finishedFormat?id=
        [HttpPut]
        public async Task<IActionResult> PutFinishedFormat(int id, FinishedFormat finishedFormat)
        {
            if (id != finishedFormat.FinishedFormatId)
            {
                return BadRequest();
            }

            _context.Entry(finishedFormat).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FinishedFormatExists(id))
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

        //http://localhost:55928/api/finishedFormat
        [HttpPost]
        public async Task<ActionResult<FinishedFormat>> PostFinishedFormat(FinishedFormat finishedFormat)
        {
            _context.finishedFormat.Add(finishedFormat);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFinishedFormat", new { id = finishedFormat.FinishedFormatId }, finishedFormat);
        }

        //http://localhost:55928/api/finishedFormat?id=
        [HttpDelete]
        public async Task<ActionResult<FinishedFormat>> DeleteFinishedFormat(int id)
        {
            var finishedFormat = await _context.finishedFormat.FindAsync(id);
            if (finishedFormat == null)
            {
                return NotFound();
            }

            _context.finishedFormat.Remove(finishedFormat);
            await _context.SaveChangesAsync();

            return finishedFormat;
        }

        private bool FinishedFormatExists(int id)
        {
            return _context.finishedFormat.Any(e => e.FinishedFormatId == id);
        }
    }
}
