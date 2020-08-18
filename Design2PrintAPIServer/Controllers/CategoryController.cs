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
    public class CategoryController : ControllerBase
    {
        private readonly DataContext _context;

        public CategoryController(DataContext context)
        {
            _context = context;
        }

        //http://localhost:55928/api/category
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category>>> Getcategory()
        {
            return await _context.category.ToListAsync();
        }

        //http://localhost:55928/api/category/getCategoryById?categoryId=
        [HttpGet]
        [Route("getCategoryById")]
        public async Task<ActionResult<IEnumerable<Category>>> getCategoryById(int categoryId)
        {
            return await _context.category.FromSqlInterpolated($"CALL getCategoryById({categoryId})").ToListAsync();
        }

        //http://localhost:55928/api/category?id=
        [HttpPut]
        public async Task<IActionResult> PutCategory(int id, Category category)
        {
            if (id != category.CategoryId)
            {
                return BadRequest();
            }

            _context.Entry(category).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CategoryExists(id))
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

        //http://localhost:55928/api/category
        [HttpPost]
        public async Task<ActionResult<Category>> PostCategory(Category category)
        {
            _context.category.Add(category);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCategory", new { id = category.CategoryId }, category);
        }

        //http://localhost:55928/api/category?id=
        [HttpDelete]
        public async Task<ActionResult<Category>> DeleteCategory(int id)
        {
            var category = await _context.category.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }

            _context.category.Remove(category);
            await _context.SaveChangesAsync();

            return category;
        }

        private bool CategoryExists(int id)
        {
            return _context.category.Any(e => e.CategoryId == id);
        }
    }
}
