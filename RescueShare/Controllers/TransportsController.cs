using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RescueShare.Models;
using RescueShare.Models.Entities;

namespace RescueShare.Controllers
{
    public class TransportsController : Controller
    {
        private readonly RescueContext _context;

        public TransportsController(RescueContext context)
        {
            _context = context;
        }

        // GET: Transports
        public async Task<IActionResult> Index()
        {
            return View();
        }

        // GET: Transports/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transport = await _context.Transports
                .Include(t => t.FosterReceiver)
                .Include(t => t.FosterSender)
                .Include(t => t.RescueReceiver)
                .Include(t => t.RescueSender)
                .Include(t => t.ShelterReceiver)
                .Include(t => t.ShelterSender)
                .Include(t => t.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (transport == null)
            {
                return NotFound();
            }

            return View(transport);
        }

        // GET: Transports/Create
        public IActionResult Create()
        {
            ViewData["FosterReceiverId"] = new SelectList(_context.Set<Foster>(), "Id", "Id");
            ViewData["FosterSenderId"] = new SelectList(_context.Set<Foster>(), "Id", "Id");
            ViewData["RescueReceiverId"] = new SelectList(_context.Set<Rescue>(), "Id", "Id");
            ViewData["RescueSenderId"] = new SelectList(_context.Set<Rescue>(), "Id", "Id");
            ViewData["ShelterReceiverId"] = new SelectList(_context.Shelters, "Id", "Id");
            ViewData["ShelterSenderId"] = new SelectList(_context.Shelters, "Id", "Id");
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: Transports/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,PickupTime,DropoffTime,TransportTime,ShelterSenderId,ShelterReceiverId,FosterSenderId,FosterReceiverId,RescueSenderId,RescueReceiverId,UserId,ReceiverType,SenderType")] Transport transport)
        {
            if (ModelState.IsValid)
            {
                _context.Add(transport);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FosterReceiverId"] = new SelectList(_context.Set<Foster>(), "Id", "Id", transport.FosterReceiverId);
            ViewData["FosterSenderId"] = new SelectList(_context.Set<Foster>(), "Id", "Id", transport.FosterSenderId);
            ViewData["RescueReceiverId"] = new SelectList(_context.Set<Rescue>(), "Id", "Id", transport.RescueReceiverId);
            ViewData["RescueSenderId"] = new SelectList(_context.Set<Rescue>(), "Id", "Id", transport.RescueSenderId);
            ViewData["ShelterReceiverId"] = new SelectList(_context.Shelters, "Id", "Id", transport.ShelterReceiverId);
            ViewData["ShelterSenderId"] = new SelectList(_context.Shelters, "Id", "Id", transport.ShelterSenderId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", transport.UserId);
            return View(transport);
        }

        // GET: Transports/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transport = await _context.Transports.FindAsync(id);
            if (transport == null)
            {
                return NotFound();
            }
            ViewData["FosterReceiverId"] = new SelectList(_context.Set<Foster>(), "Id", "Id", transport.FosterReceiverId);
            ViewData["FosterSenderId"] = new SelectList(_context.Set<Foster>(), "Id", "Id", transport.FosterSenderId);
            ViewData["RescueReceiverId"] = new SelectList(_context.Set<Rescue>(), "Id", "Id", transport.RescueReceiverId);
            ViewData["RescueSenderId"] = new SelectList(_context.Set<Rescue>(), "Id", "Id", transport.RescueSenderId);
            ViewData["ShelterReceiverId"] = new SelectList(_context.Shelters, "Id", "Id", transport.ShelterReceiverId);
            ViewData["ShelterSenderId"] = new SelectList(_context.Shelters, "Id", "Id", transport.ShelterSenderId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", transport.UserId);
            return View(transport);
        }

        // POST: Transports/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,PickupTime,DropoffTime,TransportTime,ShelterSenderId,ShelterReceiverId,FosterSenderId,FosterReceiverId,RescueSenderId,RescueReceiverId,UserId,ReceiverType,SenderType")] Transport transport)
        {
            if (id != transport.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(transport);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TransportExists(transport.Id))
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
            ViewData["FosterReceiverId"] = new SelectList(_context.Set<Foster>(), "Id", "Id", transport.FosterReceiverId);
            ViewData["FosterSenderId"] = new SelectList(_context.Set<Foster>(), "Id", "Id", transport.FosterSenderId);
            ViewData["RescueReceiverId"] = new SelectList(_context.Set<Rescue>(), "Id", "Id", transport.RescueReceiverId);
            ViewData["RescueSenderId"] = new SelectList(_context.Set<Rescue>(), "Id", "Id", transport.RescueSenderId);
            ViewData["ShelterReceiverId"] = new SelectList(_context.Shelters, "Id", "Id", transport.ShelterReceiverId);
            ViewData["ShelterSenderId"] = new SelectList(_context.Shelters, "Id", "Id", transport.ShelterSenderId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", transport.UserId);
            return View(transport);
        }

        // GET: Transports/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transport = await _context.Transports
                .Include(t => t.FosterReceiver)
                .Include(t => t.FosterSender)
                .Include(t => t.RescueReceiver)
                .Include(t => t.RescueSender)
                .Include(t => t.ShelterReceiver)
                .Include(t => t.ShelterSender)
                .Include(t => t.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (transport == null)
            {
                return NotFound();
            }

            return View(transport);
        }

        // POST: Transports/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var transport = await _context.Transports.FindAsync(id);
            _context.Transports.Remove(transport);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TransportExists(string id)
        {
            return _context.Transports.Any(e => e.Id == id);
        }
    }
}
