using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EntityFrameworkApp;

namespace WebAPIApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PainterController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public PainterController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/Painter
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Painter>>> GetPainters()
        {
            return await _context.Painters.ToListAsync();
        }

        // GET: api/Painter/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Painter>> GetPainter(int id)
        {
            var painter = await _context.Painters.FindAsync(id);

            if (painter == null)
            {
                return NotFound();
            }

            return painter;
        }

        // PUT: api/Painter/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPainter(int id, Painter painter)
        {
            if (id != painter.Id)
            {
                return BadRequest();
            }

            _context.Entry(painter).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PainterExists(id))
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

        // POST: api/Painter
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Painter>> PostPainter(Painter painter)
        {
            _context.Painters.Add(painter);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPainter", new { id = painter.Id }, painter);
        }

        // DELETE: api/Painter/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Painter>> DeletePainter(int id)
        {
            var painter = await _context.Painters.FindAsync(id);
            if (painter == null)
            {
                return NotFound();
            }

            _context.Painters.Remove(painter);
            await _context.SaveChangesAsync();

            return painter;
        }

        private bool PainterExists(int id)
        {
            return _context.Painters.Any(e => e.Id == id);
        }
    }
}
