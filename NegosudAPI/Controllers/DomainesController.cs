﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Negosud.Class;
using Negosud.Context;

namespace NegosudAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DomainesController : ControllerBase
    {
        private readonly NegosudContext _context;

        public DomainesController(NegosudContext context)
        {
            _context = context;
        }

        // GET: api/Domaines
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Domaine>>> GetDomaines()
        {
            return await _context.Domaines.ToListAsync();
        }

        // GET: api/Domaines/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Domaine>> GetDomaine(int id)
        {
            var domaine = await _context.Domaines.FindAsync(id);

            if (domaine == null)
            {
                return NotFound();
            }

            return domaine;
        }

        // PUT: api/Domaines/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDomaine(int id, Domaine domaine)
        {
            if (id != domaine.Id)
            {
                return BadRequest();
            }

            _context.Entry(domaine).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DomaineExists(id))
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

        // POST: api/Domaines
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Domaine>> PostDomaine(Domaine domaine)
        {
            _context.Domaines.Add(domaine);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDomaine", new { id = domaine.Id }, domaine);
        }

        // DELETE: api/Domaines/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDomaine(int id)
        {
            var domaine = await _context.Domaines.FindAsync(id);
            if (domaine == null)
            {
                return NotFound();
            }

            _context.Domaines.Remove(domaine);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DomaineExists(int id)
        {
            return _context.Domaines.Any(e => e.Id == id);
        }
    }
}
