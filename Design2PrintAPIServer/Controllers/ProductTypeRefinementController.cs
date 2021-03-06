﻿using System;
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
    public class ProductTypeRefinementController : ControllerBase
    {
        private readonly DataContext _context;

        public ProductTypeRefinementController(DataContext context)
        {
            _context = context;
        }

        //http://localhost:55928/api/productTypeRefinement
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductTypeRefinement>>> GetproductTypeRefinement()
        {
            return await _context.productTypeRefinement.ToListAsync();
        }

        //http://localhost:55928/api/productTypeRefinement/getAllProductTypeRefinements
        [HttpGet]
        [Route("getAllProductTypeRefinements")]
        public async Task<ActionResult<IEnumerable<ProductTypeRefinementViewModel>>> getAllProductTypeRefinements()
        {
            return await _context.productTypeRefinementViewModel.FromSqlInterpolated($"CALL getAllProductTypeRefinements").ToListAsync();
        }

        //http://localhost:55928/api/productTypeRefinement/getProRefinementById?productTypeRefinementId=
        [HttpGet]
        [Route("getProRefinementById")]
        public async Task<ActionResult<IEnumerable<ProductTypeRefinementViewModel>>> getProRefinementById(int productTypeRefinementId)
        {
            return await _context.productTypeRefinementViewModel.FromSqlInterpolated($"CALL getProRefinementById({productTypeRefinementId})").ToListAsync();
        }

        //http://localhost:55928/api/productTypeRefinement?id=
        [HttpPut]
        public async Task<IActionResult> PutProductTypeRefinement(int id, ProductTypeRefinement productTypeRefinement)
        {
            if (id != productTypeRefinement.ProductTypeRefinementId)
            {
                return BadRequest();
            }

            _context.Entry(productTypeRefinement).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductTypeRefinementExists(id))
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

        //http://localhost:55928/api/productTypeRefinement
        [HttpPost]
        public async Task<ActionResult<ProductTypeRefinement>> PostProductTypeRefinement(ProductTypeRefinement productTypeRefinement)
        {
            _context.productTypeRefinement.Add(productTypeRefinement);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProductTypeRefinement", new { id = productTypeRefinement.ProductTypeRefinementId }, productTypeRefinement);
        }

        //http://localhost:55928/api/productTypeRefinement?id=
        [HttpDelete]
        public async Task<ActionResult<ProductTypeRefinement>> DeleteProductTypeRefinement(int id)
        {
            var productTypeRefinement = await _context.productTypeRefinement.FindAsync(id);
            if (productTypeRefinement == null)
            {
                return NotFound();
            }

            _context.productTypeRefinement.Remove(productTypeRefinement);
            await _context.SaveChangesAsync();

            return productTypeRefinement;
        }

        private bool ProductTypeRefinementExists(int id)
        {
            return _context.productTypeRefinement.Any(e => e.ProductTypeRefinementId == id);
        }
    }
}
