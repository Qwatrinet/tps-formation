using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using testCpu.Models;
using testCpu.Services;

namespace testCpu.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CpuProductionsController : ControllerBase
    {
        private readonly ContextCpu _context;

        public CpuProductionsController(ContextCpu context)
        {
            _context = context;
        }

        // GET: api/CpuProductions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CpuProduction>>> GetCpuProductions()
        {
            return await _context.CpuProductions.ToListAsync();
        }

        // GET: api/CpuProductions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CpuProduction>> GetCpuProduction(int id)
        {
            var cpuProduction = await _context.CpuProductions.FindAsync(id);

            if (cpuProduction == null)
            {
                return NotFound();
            }

            return cpuProduction;
        }

        // PUT: api/CpuProductions/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCpuProduction(int id, CpuProduction cpuProduction)
        {
            if (id != cpuProduction.Id)
            {
                return BadRequest();
            }

            _context.Entry(cpuProduction).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CpuProductionExists(id))
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

        // POST: api/CpuProductions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CpuProduction>> PostCpuProduction(CpuProduction cpuProduction)
        {
            _context.CpuProductions.Add(cpuProduction);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCpuProduction", new { id = cpuProduction.Id }, cpuProduction);
        }

        // DELETE: api/CpuProductions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCpuProduction(int id)
        {
            var cpuProduction = await _context.CpuProductions.FindAsync(id);
            if (cpuProduction == null)
            {
                return NotFound();
            }

            _context.CpuProductions.Remove(cpuProduction);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CpuProductionExists(int id)
        {
            return _context.CpuProductions.Any(e => e.Id == id);
        }
    }
}
