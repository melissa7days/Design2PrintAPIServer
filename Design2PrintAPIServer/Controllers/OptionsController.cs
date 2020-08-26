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
    public class OptionsController : ControllerBase
    {
        private readonly DataContext _context;

        public OptionsController(DataContext context)
        {
            _context = context;
        }

        //http://localhost:55928/api/options
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Options>>> Getoption()
        {
            return await _context.option.ToListAsync();
        }

        //http://localhost:55928/api/options/getOptionsById?optionId=
        [HttpGet]
        [Route("getOptionsById")]
        public async Task<ActionResult<IEnumerable<Options>>> getOptionsById(int optionId)
        {
            return await _context.option.FromSqlInterpolated($"CALL getOptionsById({optionId})").ToListAsync();
        }

        //http://localhost:55928/api/options?id=
        [HttpPut]
        public async Task<IActionResult> PutOptions(int id, Options options)
        {
            if (id != options.OptionId)
            {
                return BadRequest();
            }

            _context.Entry(options).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OptionsExists(id))
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

        //http://localhost:55928/api/options
        [HttpPost]
        public async Task<ActionResult<Options>> PostOptions(Options options)
        {
            _context.option.Add(options);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOptions", new { id = options.OptionId }, options);
        }

        //http://localhost:55928/api/options?id=
        [HttpDelete]
        public async Task<ActionResult<Options>> DeleteOptions(int id)
        {
            var options = await _context.option.FindAsync(id);
            if (options == null)
            {
                return NotFound();
            }

            _context.option.Remove(options);
            await _context.SaveChangesAsync();

            return options;
        }

        private bool OptionsExists(int id)
        {
            return _context.option.Any(e => e.OptionId == id);
        }
    }
}
