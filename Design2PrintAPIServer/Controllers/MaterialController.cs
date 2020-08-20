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
    public class MaterialController : ControllerBase
    {
        private readonly DataContext _context;

        public MaterialController(DataContext context)
        {
            _context = context;
        }

        //http://localhost:55928/api/material
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Material>>> Getmaterial()
        {
            return await _context.material.ToListAsync();
        }

        //http://localhost:55928/api/material/getMaterialById?materialId=
        [HttpGet]
        [Route("getMaterialById")]
        public async Task<ActionResult<IEnumerable<Material>>> getMaterialById(int materialId)
        {
            return await _context.material.FromSqlInterpolated($"CALL getMaterialById({materialId})").ToListAsync();
        }

        //http://localhost:55928/api/material?id=
        [HttpPut]
        public async Task<IActionResult> PutMaterial(int id, Material material)
        {
            if (id != material.MaterialId)
            {
                return BadRequest();
            }

            _context.Entry(material).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MaterialExists(id))
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

        //http://localhost:55928/api/material
        [HttpPost]
        public async Task<ActionResult<Material>> PostMaterial(Material material)
        {
            _context.material.Add(material);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMaterial", new { id = material.MaterialId }, material);
        }

        //http://localhost:55928/api/material?id=
        [HttpDelete]
        public async Task<ActionResult<Material>> DeleteMaterial(int id)
        {
            var material = await _context.material.FindAsync(id);
            if (material == null)
            {
                return NotFound();
            }

            _context.material.Remove(material);
            await _context.SaveChangesAsync();

            return material;
        }

        private bool MaterialExists(int id)
        {
            return _context.material.Any(e => e.MaterialId == id);
        }
    }
}
