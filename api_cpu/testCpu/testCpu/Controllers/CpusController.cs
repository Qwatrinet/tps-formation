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
    public class CpusController : ControllerBase
    {
        private readonly ContextCpu _context;

        public CpusController(ContextCpu context)
        {
            _context = context;
        }

        // GET: api/Cpus
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cpu>>> GetCpus()
        {
            return await _context.Cpus.ToListAsync();
        }

        // GET: api/Cpus/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Cpu>> GetCpu(int id)
        {
            var cpu = await _context.Cpus.FindAsync(id);

            if (cpu == null)
            {
                return NotFound();
            }

            return cpu;
        }

        // PUT: api/Cpus/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCpu(int id, Cpu cpu)
        {
            if (id != cpu.Id)
            {
                return BadRequest();
            }

            _context.Entry(cpu).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CpuExists(id))
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

        // POST: api/Cpus
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Cpu>> PostCpu(Cpu cpu)
        {
            _context.Cpus.Add(cpu);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCpu", new { id = cpu.Id }, cpu);
        }

        // DELETE: api/Cpus/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCpu(int id)
        {
            var cpu = await _context.Cpus.FindAsync(id);
            if (cpu == null)
            {
                return NotFound();
            }

            _context.Cpus.Remove(cpu);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CpuExists(int id)
        {
            return _context.Cpus.Any(e => e.Id == id);
        }
    }
}
