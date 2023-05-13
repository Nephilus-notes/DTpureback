using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DTpureback.Data;
using DTpureback.Models.Resources;

namespace DTpureback.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterDefaultsController : ControllerBase
    {
        private readonly DragonsTailContext _context;

        public CharacterDefaultsController(DragonsTailContext context)
        {
            _context = context;
        }

        // GET: api/CharacterDefaults
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CharacterDefaultDTO>>> GetCharacterDefault()
        {
            if (_context.CharacterDefault == null)
            {
                return NotFound();
            }

            var characterDefaultDTOs = new List<CharacterDefaultDTO>();

            var templates = await _context.CharacterDefault.ToListAsync();

            foreach (var template in templates)
            {
                var associatedAbility = await _context.Ability.FindAsync(template.AbilityID);
                if (associatedAbility != null)
                {
                    var characterDefaultDTO = new CharacterDefaultDTO
                    {
                        // Copy properties from template to characterDefaultDTO
                        // For example:
                        ID = template.ID,
                        Name = template.Name,
                        Strength = template.Strength,
                        Dexterity   = template.Dexterity,
                        Constitution = template.Constitution,
                        Intelligence = template.Intelligence,
                        Description= template.Description,
                        Job = template.Job,
                        // Assign the retrieved ability
                        Ability = associatedAbility
                    };

                    characterDefaultDTOs.Add(characterDefaultDTO);
                }
            }

            return characterDefaultDTOs;
        }

        // GET: api/CharacterDefaults/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CharacterDefault>> GetCharacterDefault(string id)
        {
          if (_context.CharacterDefault == null)
          {
              return NotFound();
          }
            var characterDefault = await _context.CharacterDefault.FindAsync(id);

            if (characterDefault == null)
            {
                return NotFound();
            }

            return characterDefault;
        }

        // PUT: api/CharacterDefaults/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCharacterDefault(string id, CharacterDefault characterDefault)
        {
            if (id != characterDefault.ID)
            {
                return BadRequest();
            }

            _context.Entry(characterDefault).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CharacterDefaultExists(id))
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

        // POST: api/CharacterDefaults
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CharacterDefault>> PostCharacterDefault(CharacterDefault characterDefault)
        {
          if (_context.CharacterDefault == null)
          {
              return Problem("Entity set 'DragonsTailContext.CharacterDefault'  is null.");
          }
            _context.CharacterDefault.Add(characterDefault);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CharacterDefaultExists(characterDefault.ID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCharacterDefault", new { id = characterDefault.ID }, characterDefault);
        }

        // DELETE: api/CharacterDefaults/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCharacterDefault(string id)
        {
            if (_context.CharacterDefault == null)
            {
                return NotFound();
            }
            var characterDefault = await _context.CharacterDefault.FindAsync(id);
            if (characterDefault == null)
            {
                return NotFound();
            }

            _context.CharacterDefault.Remove(characterDefault);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CharacterDefaultExists(string id)
        {
            return (_context.CharacterDefault?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
