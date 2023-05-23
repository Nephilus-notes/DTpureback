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
    public class AbilitiesController : ControllerBase
    {
        private readonly DragonsTailContext _context;

        public AbilitiesController(DragonsTailContext context)
        {
            _context = context;
        }

        // GET: api/Abilities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ability>>> GetAbility()
        {
          if (_context.Ability == null)
          {
              return NotFound();
          }
            return await _context.Ability.ToListAsync();
        }

        // GET: api/Abilities/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ability>> GetAbility(int id)
        {
          if (_context.Ability == null)
          {
              return NotFound();
          }
            var ability = await _context.Ability.FindAsync(id);

            if (ability == null)
            {
                return NotFound();
            }

            var abilityDescendants = new List<Ability>();

            if (ability.Descendants != null)
            {
            foreach (var abilityDescendantID in ability.Descendants)
            {
                    abilityDescendants = _context.Ability.Where(a => ability.Descendants.Contains(a.ID)).ToList();
            }
            }

            var abilityDTO = new AbilityDTO()
            {

            };

            return ability;
        }

        // PUT: api/Abilities/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPatch("{id}")]
        public async Task<IActionResult> PatchAbility(int id, Ability ability)
        {
            if (id != ability.ID)
            {
                return BadRequest();
            }

            _context.Entry(ability).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AbilityExists(id))
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

        // POST: api/Abilities
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Ability>> PostAbility(Ability ability)
        {
          if (_context.Ability == null)
          {
              return Problem("Entity set 'DragonsTailContext.Ability'  is null.");
          }
            _context.Ability.Add(ability);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (AbilityExists(ability.ID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetAbility", new { id = ability.ID }, ability);
        }

        // DELETE: api/Abilities/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAbility(int id)
        {
            if (_context.Ability == null)
            {
                return NotFound();
            }
            var ability = await _context.Ability.FindAsync(id);
            if (ability == null)
            {
                return NotFound();
            }

            _context.Ability.Remove(ability);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AbilityExists(int id)
        {
            return (_context.Ability?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
