using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RescueShare.Models;

namespace RescueShare.Controllers
{
    public class SheltersController : Controller
    {
        private readonly RescueContext _context;

        public SheltersController(RescueContext context)
        {
            _context = context;
        }

        // GET: Shelters
        public async Task<IActionResult> Index()
        {
            var shelter = await _context.ShelterMembers
                .Include(sm => sm.Shelter)
                .Where(sm => sm.UserId == User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value)
                .Select(sm => sm.Shelter)
                .FirstOrDefaultAsync();
            if (shelter == null)
            {
                return NotFound();
            }
            return View(shelter);
        }

        // GET: Shelters/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            

            var shelter = await _context.Shelters
                .FirstOrDefaultAsync(m => m.Id == id);
            if (shelter == null)
            {
                return NotFound();
            }

            return View(shelter);
        }

        // GET: Shelters/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Shelters/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Address1,Address2,City,State,Zip,Phone,Email")] Shelter shelter)
        {
            if (ModelState.IsValid)
            {
                _context.Add(shelter);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(shelter);
        }

        // GET: Shelters/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shelter = await _context.Shelters.FindAsync(id);
            if (shelter == null)
            {
                return NotFound();
            }
            return View(shelter);
        }

        // POST: Shelters/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Name,Address1,Address2,City,State,Zip,Phone,Email")] Shelter shelter)
        {
            if (id != shelter.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(shelter);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ShelterExists(shelter.Id))
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
            return View(shelter);
        }

        // GET: Shelters/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shelter = await _context.Shelters
                .FirstOrDefaultAsync(m => m.Id == id);
            if (shelter == null)
            {
                return NotFound();
            }

            return View(shelter);
        }

        // POST: Shelters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var shelter = await _context.Shelters.FindAsync(id);
            _context.Shelters.Remove(shelter);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ShelterExists(string id)
        {
            return _context.Shelters.Any(e => e.Id == id);
        }
    }
}
