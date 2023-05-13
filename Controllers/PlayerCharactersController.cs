using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DTpureback.Data;
using DTpureback.Models;
using DTpureback.Models.Resources;
using AutoMapper;

namespace DTpureback.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerCharactersController : ControllerBase
    {
        private readonly DragonsTailContext _context;
        private readonly IMapper _mapper;

        public PlayerCharactersController(DragonsTailContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/PlayerCharacters
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PlayerCharacter>>> GetPlayerCharacters()
        {
          if (_context.PlayerCharacters == null)
          {
              return NotFound();
          }
            return await _context.PlayerCharacters.ToListAsync();
        }

        // GET: api/PlayerCharacters/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PlayerCharacterDTO>> GetPlayerCharacter(int id)
        {
            var playerCharacter = await _context.PlayerCharacters
                .FirstOrDefaultAsync(pc => pc.ID == id);

            if (playerCharacter == null)
            {
                return NotFound();
            }

            // var playerCharacterDto = _mapper.Map<PlayerCharacterDTO>(playerCharacter);

            var associatedItems = _context.Items.Where(i => playerCharacter.Items.Contains(i.ID)).ToList();
            var associatedAbilities = _context.Ability.Where(i => playerCharacter.Abilities.Contains(i.ID)).ToList();

            var playerCharacterDto = new PlayerCharacterDTO
            {
                ID = playerCharacter.ID,
                Name = playerCharacter.Name,
                CurrentCurrency = playerCharacter.CurrentCurrency,
                MaxHP = playerCharacter.MaxHP,
                MaxMP = playerCharacter.MaxMP,
                CurrentHP= playerCharacter.CurrentHP,
                CurrentMP= playerCharacter.CurrentMP,
                CurrentLocation= playerCharacter.CurrentLocation,
                LifeTimeCurrency= playerCharacter.LifeTimeCurrency,
                Armor = playerCharacter.Armor,
                Resistance = playerCharacter.Resistance,
                Strength = playerCharacter.Strength,
                StrengthXP = playerCharacter.StrengthXP,
                Dexterity = playerCharacter.Dexterity,
                DexterityXP = playerCharacter.DexterityXP,
                Constitution = playerCharacter.Constitution,
                ConstitutionXP = playerCharacter.ConstitutionXP,
                Intelligence= playerCharacter.Intelligence,
                IntelligenceXP= playerCharacter.IntelligenceXP,
                DateAdded= playerCharacter.DateAdded,
                DateUpdated= playerCharacter.DateUpdated,
                DrippingDeathExplored= playerCharacter.DrippingDeathExplored,
                TailOfTheDragonExplored= playerCharacter.TailOfTheDragonExplored,
                WebOfDepthsExplored= playerCharacter.WebOfDepthsExplored,
                EquippedItems = playerCharacter.EquippedItems,
                GraithQueensLairExplored= playerCharacter.GraithQueensLairExplored,
                GraithsGrottoExplored= playerCharacter.GraithsGrottoExplored,
                KratabsFollyExplored= playerCharacter.KratabsFollyExplored,
                PlayersRespiteExplored= playerCharacter.PlayersRespiteExplored,
                ThagragsHopeExplored= playerCharacter.ThagragsHopeExplored,
                Level = playerCharacter.Level,
                Items = associatedItems,
                Abilities = associatedAbilities,
            };


            return playerCharacterDto;
        }

        // PUT: api/PlayerCharacters/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPatch("{id}")]
        public async Task<IActionResult> PutPlayerCharacter(int id, PlayerCharacter playerCharacter)
        {
            if (id != playerCharacter.ID)
            {
                return BadRequest();
            }

            _context.Entry(playerCharacter).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlayerCharacterExists(id))
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

        // POST: api/PlayerCharacters
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PlayerCharacter>> PostPlayerCharacter(PlayerCharacter playerCharacter)
        {
          if (_context.PlayerCharacters == null)
          {
              return Problem("Entity set 'DragonsTailContext.PlayerCharacters'  is null.");
          }
            _context.PlayerCharacters.Add(playerCharacter);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPlayerCharacter", new { id = playerCharacter.ID }, playerCharacter);
        }

        // DELETE: api/PlayerCharacters/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePlayerCharacter(int id)
        {
            if (_context.PlayerCharacters == null)
            {
                return NotFound();
            }
            var playerCharacter = await _context.PlayerCharacters.FindAsync(id);
            if (playerCharacter == null)
            {
                return NotFound();
            }

            _context.PlayerCharacters.Remove(playerCharacter);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PlayerCharacterExists(int id)
        {
            return (_context.PlayerCharacters?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
