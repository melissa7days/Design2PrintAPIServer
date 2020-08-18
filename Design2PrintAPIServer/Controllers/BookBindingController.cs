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
    public class BookBindingController : ControllerBase
    {
        private readonly DataContext _context;

        public BookBindingController(DataContext context)
        {
            _context = context;
        }

        //http://localhost:55928/api/bookbinding
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookBinding>>> GetbookBinding()
        {
            return await _context.bookBinding.ToListAsync();
        }

        //http://localhost:55928/api/bookbinding/getBookBindingById?bookBindingId=
        [HttpGet]
        [Route("getBookBindingById")]
        public async Task<ActionResult<IEnumerable<BookBinding>>> getBookBindingById(int bookBindingId)
        {
            return await _context.bookBinding.FromSqlInterpolated($"CALL getBookBindingById({bookBindingId})").ToListAsync();
        }

        //http://localhost:55928/api/bookbinding?id=
        [HttpPut]
        public async Task<IActionResult> PutBookBinding(int id, BookBinding bookBinding)
        {
            if (id != bookBinding.BookBindingId)
            {
                return BadRequest();
            }

            _context.Entry(bookBinding).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookBindingExists(id))
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

        //http://localhost:55928/api/bookbinding
        [HttpPost]
        public async Task<ActionResult<BookBinding>> PostBookBinding(BookBinding bookBinding)
        {
            _context.bookBinding.Add(bookBinding);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBookBinding", new { id = bookBinding.BookBindingId }, bookBinding);
        }

        //http://localhost:55928/api/bookbinding?id=
        [HttpDelete]
        public async Task<ActionResult<BookBinding>> DeleteBookBinding(int id)
        {
            var bookBinding = await _context.bookBinding.FindAsync(id);
            if (bookBinding == null)
            {
                return NotFound();
            }

            _context.bookBinding.Remove(bookBinding);
            await _context.SaveChangesAsync();

            return bookBinding;
        }

        private bool BookBindingExists(int id)
        {
            return _context.bookBinding.Any(e => e.BookBindingId == id);
        }
    }
}
