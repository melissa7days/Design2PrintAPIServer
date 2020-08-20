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
    public class PDFController : ControllerBase
    {
        private readonly DataContext _context;

        public PDFController(DataContext context)
        {
            _context = context;
        }

        //http://localhost:55928/api/pdf
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PDF>>> Getpdf()
        {
            return await _context.pdf.ToListAsync();
        }

        //http://localhost:55928/api/pdf/getPDFById?pdfId=
        [HttpGet]
        [Route("getPDFById")]
        public async Task<ActionResult<IEnumerable<PDF>>> getPDFById(int pdfId)
        {
            return await _context.pdf.FromSqlInterpolated($"CALL getPDFById({pdfId})").ToListAsync();
        }

        //http://localhost:55928/api/pdf?id=
        [HttpPut]
        public async Task<IActionResult> PutPDF(int id, PDF pDF)
        {
            if (id != pDF.PDFId)
            {
                return BadRequest();
            }

            _context.Entry(pDF).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PDFExists(id))
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

        //http://localhost:55928/api/pdf
        [HttpPost]
        public async Task<ActionResult<PDF>> PostPDF(PDF pDF)
        {
            _context.pdf.Add(pDF);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPDF", new { id = pDF.PDFId }, pDF);
        }

        //http://localhost:55928/api/pdf?id=
        [HttpDelete]
        public async Task<ActionResult<PDF>> DeletePDF(int id)
        {
            var pDF = await _context.pdf.FindAsync(id);
            if (pDF == null)
            {
                return NotFound();
            }

            _context.pdf.Remove(pDF);
            await _context.SaveChangesAsync();

            return pDF;
        }

        private bool PDFExists(int id)
        {
            return _context.pdf.Any(e => e.PDFId == id);
        }
    }
}
