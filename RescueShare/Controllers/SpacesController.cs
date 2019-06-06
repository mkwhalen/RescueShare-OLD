using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RescueShare.Models;
using RescueShare.Models.Entities;
using System.Web.Mvc.Html;

namespace RescueShare.Controllers
{
    public class SpacesController : Controller
    {
        private readonly RescueContext _context;

        public SpacesController(RescueContext context)
        {
            _context = context;
        }

        // GET: Spaces
        public async Task<IActionResult> Index()
        {
            var rescueContext = _context.Spaces.Include(s => s.Shelter);
            return View(await rescueContext.ToListAsync());
        }

        // GET: Spaces/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var space = await _context.Spaces
                .Include(s => s.Shelter)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (space == null)
            {
                return NotFound();
            }

            return View(space);
        }

        // GET: Spaces/Create
        public IActionResult Create()
        {
            ViewData["ShelterId"] = new SelectList(_context.Shelters, "Id", "Id");
            return View();
        }
        

        // POST: Spaces/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Capacity,Type,ShelterId,Notes")] Space space)
        {
            if (ModelState.IsValid)
            {
                _context.Add(space);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ShelterId"] = new SelectList(_context.Shelters, "Id", "Id", space.ShelterId);
            return View(space);
        }

        // GET: Spaces/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var space = await _context.Spaces.FindAsync(id);
            if (space == null)
            {
                return NotFound();
            }
            ViewData["ShelterId"] = new SelectList(_context.Shelters, "Id", "Id", space.ShelterId);
            return View(space);
        }

        // POST: Spaces/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Name,Capacity,Type,ShelterId,Notes")] Space space)
        {
            if (id != space.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(space);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SpaceExists(space.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ShelterId"] = new SelectList(_context.Shelters, "Id", "Id", space.ShelterId);
            return View(space);
        }

        // GET: Spaces/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var space = await _context.Spaces
                .Include(s => s.Shelter)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (space == null)
            {
                return NotFound();
            }

            return View(space);
        }

        // POST: Spaces/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var space = await _context.Spaces.FindAsync(id);
            _context.Spaces.Remove(space);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SpaceExists(string id)
        {
            return _context.Spaces.Any(e => e.Id == id);
        }
    }
}
