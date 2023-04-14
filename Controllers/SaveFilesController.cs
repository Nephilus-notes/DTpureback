using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DTpureback.Data;
using DTpureback.Models;

namespace DTpureback.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaveFilesController : ControllerBase
    {
        private readonly DragonsTailContext _context;

        public SaveFilesController(DragonsTailContext context)
        {
            _context = context;
        }

        // GET: api/SaveFiles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SaveFile>>> GetSaveFiles()
        {
          if (_context.SaveFiles == null)
          {
              return NotFound();
          }
            return await _context.SaveFiles.ToListAsync();
        }

        // GET: api/SaveFiles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SaveFile>> GetSaveFile(int id)
        {
          if (_context.SaveFiles == null)
          {
              return NotFound();
          }
            var saveFile = await _context.SaveFiles.FindAsync(id);

            if (saveFile == null)
            {
                return NotFound();
            }

            return saveFile;
        }

        // PUT: api/SaveFiles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSaveFile(int id, SaveFile saveFile)
        {
            if (id != saveFile.ID)
            {
                return BadRequest();
            }

            _context.Entry(saveFile).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SaveFileExists(id))
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

        // POST: api/SaveFiles
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SaveFile>> PostSaveFile(SaveFile saveFile)
        {
          if (_context.SaveFiles == null)
          {
              return Problem("Entity set 'DragonsTailContext.SaveFiles'  is null.");
          }
            _context.SaveFiles.Add(saveFile);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSaveFile", new { id = saveFile.ID }, saveFile);
        }

        // DELETE: api/SaveFiles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSaveFile(int id)
        {
            if (_context.SaveFiles == null)
            {
                return NotFound();
            }
            var saveFile = await _context.SaveFiles.FindAsync(id);
            if (saveFile == null)
            {
                return NotFound();
            }

            _context.SaveFiles.Remove(saveFile);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SaveFileExists(int id)
        {
            return (_context.SaveFiles?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
