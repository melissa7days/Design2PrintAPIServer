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
    public class PagesController : ControllerBase
    {
        private readonly DataContext _context;

        public PagesController(DataContext context)
        {
            _context = context;
        }

        //http://localhost:55928/api/pages
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pages>>> Getpages()
        {
            return await _context.pages.ToListAsync();
        }

        //http://localhost:55928/api/pages/getPageById?pageId=
        [HttpGet]
        [Route("getPageById")]
        public async Task<ActionResult<IEnumerable<Pages>>> getPageById(int pageId)
        {
            return await _context.pages.FromSqlInterpolated($"CALL getPageById({pageId})").ToListAsync();
        }

        //http://localhost:55928/api/pages?id=
        [HttpPut]
        public async Task<IActionResult> PutPages(int id, Pages pages)
        {
            if (id != pages.PageId)
            {
                return BadRequest();
            }

            _context.Entry(pages).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PagesExists(id))
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

        //http://localhost:55928/api/pages
        [HttpPost]
        public async Task<ActionResult<Pages>> PostPages(Pages pages)
        {
            _context.pages.Add(pages);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPages", new { id = pages.PageId }, pages);
        }

        //http://localhost:55928/api/pages?id=
        [HttpDelete]
        public async Task<ActionResult<Pages>> DeletePages(int id)
        {
            var pages = await _context.pages.FindAsync(id);
            if (pages == null)
            {
                return NotFound();
            }

            _context.pages.Remove(pages);
            await _context.SaveChangesAsync();

            return pages;
        }

        private bool PagesExists(int id)
        {
            return _context.pages.Any(e => e.PageId == id);
        }
    }
}
