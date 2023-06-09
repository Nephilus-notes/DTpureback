﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DTpureback.Data;
using Microsoft.AspNetCore.Cors;
using DTpureback.Models.Resources;
using DTpureback.Models;

namespace DTpureback.Controllers
{
    [Route($"api/{"location"}")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly DragonsTailContext _context;

        public LocationController(DragonsTailContext context)
        {
            _context = context;
        }

        // GET: api/Location
        [EnableCors]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Location>>> GetLocations()
        {
          if (_context.Locations == null)
          {
              return NotFound();
          }
            return await _context.Locations.ToListAsync();
        }

        // GET: api/Location/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LocationDTO>> GetLocation(string id)
        {
            var location = await _context.Locations.FindAsync(id.ToUpper());
            if (location == null)
            {
                return NotFound();
            }
            var returnLocation = new LocationDTO
                {
                    ID = location.ID,
                    Name = location.Name,
                    EnterText = location.EnterText,
                    MiddleText = location.MiddleText,
                    ExitText = location.ExitText,
                    OtherText = location.OtherText,
                };

            if(location.MoveOptions != null)
            {

                List<string> list = new List<string>();
                var moveOptionsStrings = list;
                    foreach ( var moveOption in location.MoveOptions )
                {
                    if(moveOption != ',')
                    {
                        moveOptionsStrings.Add(moveOption.ToString());
                    }
                }
                returnLocation.MoveOptions =  _context.Locations.Where(l => moveOptionsStrings.Contains(l.ID)).ToList();
                ;
            }
            if(location.OtherList != null)
            {
                returnLocation.OtherList = location.OtherList;
            }

            if(location.Next != null)
            {
                returnLocation.Next = location.Next;
            }

            if (location.CommonNPC != null)
            {
                returnLocation.CommonNPC = location.CommonNPC;
            }

            if (location.UncommonNPC != null)
            {
                returnLocation.UncommonNPC = location.UncommonNPC;
            }

            if (location.RareNPC != null)
            {
                returnLocation.RareNPC = location.RareNPC;
            }
            if (location.SecretNPC != null)
            {
                returnLocation.SecretNPC = location.SecretNPC;
            }
           
            return returnLocation;
        }

        // PUT: api/Locations1/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPatch("{id}")]
        public async Task<IActionResult> PutLocation(string id, Location location)
        {
            if (id != location.ID)
            {
                return BadRequest();
            }

            _context.Entry(location).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LocationExists(id))
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

        // POST: api/Locations1
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Location>> PostLocation(Location location)
        {
          if (_context.Locations == null)
          {
              return Problem("Entity set 'DragonsTailContext.Locations'  is null.");
          }
            _context.Locations.Add(location);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (LocationExists(location.ID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetLocation", new { id = location.ID }, location);
        }

        // DELETE: api/Locations1/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLocation(string id)
        {
            if (_context.Locations == null)
            {
                return NotFound();
            }
            var location = await _context.Locations.FindAsync(id);
            if (location == null)
            {
                return NotFound();
            }

            _context.Locations.Remove(location);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LocationExists(string id)
        {
            return (_context.Locations?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
