using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DTpureback.Data;
using DTpureback.Models.Resources;
using DTpureback.Models;

namespace DTpureback.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NPCController : ControllerBase
    {
        private readonly DragonsTailContext _context;

        public NPCController(DragonsTailContext context)
        {
            _context = context;
        }

        // GET: api/NPCs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NPC>>> GetNPC()
        {
          if (_context.NPC == null)
          {
              return NotFound();
          }
            return await _context.NPC.ToListAsync();
        }

        // GET: api/NPCs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<NPC>> GetNPC(int id)
        {
          if (_context.NPC == null)
          {
              return NotFound();
          }
            var nPC = await _context.NPC.FindAsync(id);

            if (nPC == null)
            {
                return NotFound();
            }

            var associatedItems = _context.Items.Where(i => nPC.Items.Contains(i.ID)).ToList();
            var associatedAbilities = _context.Ability.Where(i => nPC.Abilities.Contains(i.ID)).ToList();

            var npcDTO = new NPCDTO
            {
                ID = nPC.ID,
                Name = nPC.Name,
                CurrentCurrency = nPC.CurrentCurrency,
                Armor = nPC.Armor,
                Resistance = nPC.Resistance,
                Strength = nPC.Strength,
                Dexterity = nPC.Dexterity,
                Constitution = nPC.Constitution,
                Intelligence = nPC.Intelligence,
                DateAdded = nPC.DateAdded,
                DateUpdated = nPC.DateUpdated,
                Level = nPC.Level,
                Items = associatedItems,
                Abilities = associatedAbilities,
            };


            return npcDTO;
        }

        // PUT: api/NPCs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPatch("{id}")]
        public async Task<IActionResult> PutNPC(int id, NPC nPC)
        {
            if (id != nPC.ID)
            {
                return BadRequest();
            }

            _context.Entry(nPC).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NPCExists(id))
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

        // POST: api/NPCs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<NPC>> PostNPC(NPC nPC)
        {
          if (_context.NPC == null)
          {
              return Problem("Entity set 'DragonsTailContext.NPC'  is null.");
          }
            _context.NPC.Add(nPC);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetNPC", new { id = nPC.ID }, nPC);
        }

        // DELETE: api/NPCs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNPC(int id)
        {
            if (_context.NPC == null)
            {
                return NotFound();
            }
            var nPC = await _context.NPC.FindAsync(id);
            if (nPC == null)
            {
                return NotFound();
            }

            _context.NPC.Remove(nPC);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool NPCExists(int id)
        {
            return (_context.NPC?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
