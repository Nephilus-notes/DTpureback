﻿using System;
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
    public class PlayerCharactersController : ControllerBase
    {
        private readonly DragonsTailContext _context;

        public PlayerCharactersController(DragonsTailContext context)
        {
            _context = context;
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
        public async Task<ActionResult<PlayerCharacter>> GetPlayerCharacter(int id)
        {
          if (_context.PlayerCharacters == null)
          {
              return NotFound();
          }
            var playerCharacter = await _context.PlayerCharacters.FindAsync(id);

            if (playerCharacter.ItemIDs == null)
            {
                //playerCharacter.Backpack == 
            }
            if (playerCharacter == null)
            {
                return NotFound();
            }

            return playerCharacter;
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
