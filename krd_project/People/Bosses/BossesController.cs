using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using krd_project.API.Data;

namespace krd_project.API.People.Bosses
{
    [Route("api/[controller]")]
    [ApiController]
    public class BossesController : ControllerBase
    {
        private readonly DataContext _context;

        public BossesController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Bosses
        [HttpGet]
        public async Task<IActionResult> GetBosses()
        {
			var bosses = await _context.Bosses.ToListAsync();

	        return Ok(bosses);
		}

        // GET: api/Bosses/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBoss([FromRoute] int id)
        {
			var boss = await _context.Bosses.FirstOrDefaultAsync(x => x.Id == id);

	        return Ok(boss);
		}

        // PUT: api/Bosses/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBoss([FromRoute] int id, [FromBody] Boss boss)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != boss.Id)
            {
                return BadRequest();
            }

            _context.Entry(boss).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BossExists(id))
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

        // POST: api/Bosses
        [HttpPost]
        public async Task<IActionResult> PostBoss([FromBody] Boss boss)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Bosses.Add(boss);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBoss", new { id = boss.Id }, boss);
        }

        // DELETE: api/Bosses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBoss([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var boss = await _context.Bosses.FindAsync(id);
            if (boss == null)
            {
                return NotFound();
            }

            _context.Bosses.Remove(boss);
            await _context.SaveChangesAsync();

            return Ok(boss);
        }

        private bool BossExists(int id)
        {
            return _context.Bosses.Any(e => e.Id == id);
        }
    }
}