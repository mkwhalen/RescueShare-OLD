using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RescueShare.Models;

namespace RescueShare.Controllers
{
    public class DogsController : Controller
    {
        private readonly RescueContext _context;

        public DogsController(RescueContext context)
        {
            _context = context;
        }

        // GET: Dogs
        public async Task<IActionResult> Index()
        {
            var rescueContext = _context.Dogs.Include(d => d.Shelter).Include(d => d.Space);
            return View(await rescueContext.ToListAsync());
        }

        // GET: Dogs/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dog = await _context.Dogs
                .Include(d => d.Shelter)
                .Include(d => d.Space)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dog == null)
            {
                return NotFound();
            }

            return View(dog);
        }

        // GET: Dogs/Create
        public IActionResult Create()
        {
            ViewData["ShelterId"] = new SelectList(_context.Shelters, "Id", "Id");
            ViewData["SpaceId"] = new SelectList(_context.Spaces, "Id", "Id");
            return View();
        }

        // POST: Dogs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Weight,Age,InDate,OutDate,Breed,CurrentMedications,CurrentInjuries,Food,Notes,Flag,IsSaved,SpaceId,ShelterId")] Dog dog)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dog);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ShelterId"] = new SelectList(_context.Shelters, "Id", "Id", dog.ShelterId);
            ViewData["SpaceId"] = new SelectList(_context.Spaces, "Id", "Id", dog.SpaceId);
            return View(dog);
        }

        // GET: Dogs/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dog = await _context.Dogs.FindAsync(id);
            if (dog == null)
            {
                return NotFound();
            }
            ViewData["ShelterId"] = new SelectList(_context.Shelters, "Id", "Id", dog.ShelterId);
            ViewData["SpaceId"] = new SelectList(_context.Spaces, "Id", "Id", dog.SpaceId);
            return View(dog);
        }

        // POST: Dogs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Name,Weight,Age,InDate,OutDate,Breed,CurrentMedications,CurrentInjuries,Food,Notes,Flag,IsSaved,SpaceId,ShelterId")] Dog dog)
        {
            if (id != dog.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dog);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DogExists(dog.Id))
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
            ViewData["ShelterId"] = new SelectList(_context.Shelters, "Id", "Id", dog.ShelterId);
            ViewData["SpaceId"] = new SelectList(_context.Spaces, "Id", "Id", dog.SpaceId);
            return View(dog);
        }

        // GET: Dogs/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dog = await _context.Dogs
                .Include(d => d.Shelter)
                .Include(d => d.Space)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dog == null)
            {
                return NotFound();
            }

            return View(dog);
        }

        // POST: Dogs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var dog = await _context.Dogs.FindAsync(id);
            _context.Dogs.Remove(dog);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DogExists(string id)
        {
            return _context.Dogs.Any(e => e.Id == id);
        }
    }
}
