using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Design2PrintAPIServer.Data;
using Design2PrintAPIServer.Models;
using Design2PrintAPIServer.Models.CustomModels;

namespace Design2PrintAPIServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductTypeDesignServiceController : ControllerBase
    {
        private readonly DataContext _context;

        public ProductTypeDesignServiceController(DataContext context)
        {
            _context = context;
        }

        //http://localhost:55928/api/productTypeDesignService
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductTypeDesignService>>> GetproductTypeDesignService()
        {
            return await _context.productTypeDesignService.ToListAsync();
        }

        //http://localhost:55928/api/productTypeDesignService/getProDesignServById?designServiceId=
        [HttpGet]
        [Route("getProDesignServById")]
        public async Task<ActionResult<IEnumerable<ProductTypeDesignServiceViewModel>>> getProDesignServById(int designServiceId)
        {
            return await _context.productTypeDesignServiceViewModel.FromSqlInterpolated($"CALL getProDesignServById({designServiceId})").ToListAsync();
        }

        //http://localhost:55928/api/productTypeDesignService?id=
        [HttpPut]
        public async Task<IActionResult> PutProductTypeDesignService(int id, ProductTypeDesignService productTypeDesignService)
        {
            if (id != productTypeDesignService.ProductTypeDesignServiceId)
            {
                return BadRequest();
            }

            _context.Entry(productTypeDesignService).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductTypeDesignServiceExists(id))
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

        //http://localhost:55928/api/productTypeDesignService
        [HttpPost]
        public async Task<ActionResult<ProductTypeDesignService>> PostProductTypeDesignService(ProductTypeDesignService productTypeDesignService)
        {
            _context.productTypeDesignService.Add(productTypeDesignService);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProductTypeDesignService", new { id = productTypeDesignService.ProductTypeDesignServiceId }, productTypeDesignService);
        }

        //http://localhost:55928/api/productTypeDesignService?id=
        [HttpDelete]
        public async Task<ActionResult<ProductTypeDesignService>> DeleteProductTypeDesignService(int id)
        {
            var productTypeDesignService = await _context.productTypeDesignService.FindAsync(id);
            if (productTypeDesignService == null)
            {
                return NotFound();
            }

            _context.productTypeDesignService.Remove(productTypeDesignService);
            await _context.SaveChangesAsync();

            return productTypeDesignService;
        }

        private bool ProductTypeDesignServiceExists(int id)
        {
            return _context.productTypeDesignService.Any(e => e.ProductTypeDesignServiceId == id);
        }
    }
}
