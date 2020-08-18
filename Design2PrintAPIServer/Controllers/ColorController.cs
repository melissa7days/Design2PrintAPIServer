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
    public class ColorController : ControllerBase
    {
        private readonly DataContext _context;

        public ColorController(DataContext context)
        {
            _context = context;
        }

        //http://localhost:55928/api/color
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Color>>> Getcolor()
        {
            return await _context.color.ToListAsync();
        }

        //http://localhost:55928/api/color/getColorById?colorId=
        [HttpGet]
        [Route("getColorById")]
        public async Task<ActionResult<IEnumerable<Color>>> getColorById(int colorId)
        {
            return await _context.color.FromSqlInterpolated($"CALL getColorById({colorId})").ToListAsync();
        }

        //http://localhost:55928/api/color?id=
        [HttpPut]
        public async Task<IActionResult> PutColor(int id, Color color)
        {
            if (id != color.ColorId)
            {
                return BadRequest();
            }

            _context.Entry(color).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ColorExists(id))
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

        //http://localhost:55928/api/color
        [HttpPost]
        public async Task<ActionResult<Color>> PostColor(Color color)
        {
            _context.color.Add(color);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetColor", new { id = color.ColorId }, color);
        }

        //http://localhost:55928/api/color?id=
        [HttpDelete]
        public async Task<ActionResult<Color>> DeleteColor(int id)
        {
            var color = await _context.color.FindAsync(id);
            if (color == null)
            {
                return NotFound();
            }

            _context.color.Remove(color);
            await _context.SaveChangesAsync();

            return color;
        }

        private bool ColorExists(int id)
        {
            return _context.color.Any(e => e.ColorId == id);
        }
    }
}
