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
    public class DesignServiceController : ControllerBase
    {
        private readonly DataContext _context;

        public DesignServiceController(DataContext context)
        {
            _context = context;
        }

        //http://localhost:55928/api/designService
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DesignService>>> GetdesignService()
        {
            return await _context.designService.ToListAsync();
        }

        //http://localhost:55928/api/designService/getDesignServiceById?designServiceId=
        [HttpGet]
        [Route("getDesignServiceById")]
        public async Task<ActionResult<IEnumerable<DesignService>>> getDesignServiceById(int designServiceId)
        {
            return await _context.designService.FromSqlInterpolated($"CALL getDesignServiceById({designServiceId})").ToListAsync();
        }

        //http://localhost:55928/api/designService?id=
        [HttpPut]
        public async Task<IActionResult> PutDesignService(int id, DesignService designService)
        {
            if (id != designService.DesignServiceId)
            {
                return BadRequest();
            }

            _context.Entry(designService).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DesignServiceExists(id))
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

        //http://localhost:55928/api/designService
        [HttpPost]
        public async Task<ActionResult<DesignService>> PostDesignService(DesignService designService)
        {
            _context.designService.Add(designService);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDesignService", new { id = designService.DesignServiceId }, designService);
        }

        //http://localhost:55928/api/designService?id=
        [HttpDelete]
        public async Task<ActionResult<DesignService>> DeleteDesignService(int id)
        {
            var designService = await _context.designService.FindAsync(id);
            if (designService == null)
            {
                return NotFound();
            }

            _context.designService.Remove(designService);
            await _context.SaveChangesAsync();

            return designService;
        }

        private bool DesignServiceExists(int id)
        {
            return _context.designService.Any(e => e.DesignServiceId == id);
        }
    }
}
