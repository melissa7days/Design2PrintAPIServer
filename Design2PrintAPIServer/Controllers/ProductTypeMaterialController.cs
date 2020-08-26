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
    public class ProductTypeMaterialController : ControllerBase
    {
        private readonly DataContext _context;

        public ProductTypeMaterialController(DataContext context)
        {
            _context = context;
        }

        //http://localhost:55928/api/productTypeMaterial
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductTypeMaterial>>> GetproductTypeMaterial()
        {
            return await _context.productTypeMaterial.ToListAsync();
        }

        //http://localhost:55928/api/productTypeMaterial/getProMaterialById?materialId=
        [HttpGet]
        [Route("getProMaterialById")]
        public async Task<ActionResult<IEnumerable<ProductTypeMaterial>>> getProMaterialById(int materialId)
        {
            return await _context.productTypeMaterial.FromSqlInterpolated($"CALL getProMaterialById({materialId})").ToListAsync();
        }

        //http://localhost:55928/api/productTypeMaterial?id=
        [HttpPut]
        public async Task<IActionResult> PutProductTypeMaterial(int id, ProductTypeMaterial productTypeMaterial)
        {
            if (id != productTypeMaterial.ProductTypeMaterialId)
            {
                return BadRequest();
            }

            _context.Entry(productTypeMaterial).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductTypeMaterialExists(id))
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

        //http://localhost:55928/api/productTypeMaterial
        [HttpPost]
        public async Task<ActionResult<ProductTypeMaterial>> PostProductTypeMaterial(ProductTypeMaterial productTypeMaterial)
        {
            _context.productTypeMaterial.Add(productTypeMaterial);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProductTypeMaterial", new { id = productTypeMaterial.ProductTypeMaterialId }, productTypeMaterial);
        }

        //http://localhost:55928/api/productTypeMaterial?id=
        [HttpDelete]
        public async Task<ActionResult<ProductTypeMaterial>> DeleteProductTypeMaterial(int id)
        {
            var productTypeMaterial = await _context.productTypeMaterial.FindAsync(id);
            if (productTypeMaterial == null)
            {
                return NotFound();
            }

            _context.productTypeMaterial.Remove(productTypeMaterial);
            await _context.SaveChangesAsync();

            return productTypeMaterial;
        }

        private bool ProductTypeMaterialExists(int id)
        {
            return _context.productTypeMaterial.Any(e => e.ProductTypeMaterialId == id);
        }
    }
}
