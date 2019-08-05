using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RescueShare.Models;
using RescueShare.Models.Entities;

namespace RescueShare.Controllers
{
    public class OrganizationsController : Controller
    {
        private readonly RescueContext _context;

        public OrganizationsController(RescueContext context)
        {
            _context = context;
        }

        public IActionResult ManageSpaces()
        { 
            return View(new List<Space>());
        }

        public IActionResult ManageDogs()
        {
            return View(new List<Dog>());
        }

        //public async Task<IActionResult> ManageTransports()
        //{
        //    var rescueContext = _context.Transports.Include(t => t.FosterReceiver).Include(t => t.FosterSender).Include(t => t.RescueReceiver).Include(t => t.RescueSender).Include(t => t.OrganizationReceiver).Include(t => t.OrganizationSender).Include(t => t.User);
        //    var transports = await rescueContext.ToListAsync();
        //    var viewmodels = transports.Select(t => new TransportViewModel(t));
        //    return View(viewmodels);
        //}

        // GET: Organizations
        public async Task<IActionResult> Index()
        {
            var organization = await _context.OrganizationMembers
                .Include(sm => sm.Organization)
                .Where(sm => sm.UserId == User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value)
                .Select(sm => sm.Organization)
                .FirstOrDefaultAsync();
            if (organization == null)
            {
                return NotFound();
            }
            return View(organization);
        }

        // GET: Organizations/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            

            var organization = await _context.Organizations
                .FirstOrDefaultAsync(m => m.Id == id);
            if (organization == null)
            {
                return NotFound();
            }

            return View(organization);
        }

        // GET: Organizations/Create
        public IActionResult Create()
        {
            return View();
        }

        // GET: Organizations/Images
        [HttpGet]
        public IActionResult Image()
        {
            using (RescueContext dbContext = new RescueContext())
            {
                List<string> iamgeIds = dbContext.Images.Select(m => m.Id).ToList();
                return View(iamgeIds);
            }
        }

        // POST: Organizations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Address1,Address2,City,State,Zip,Phone,Email")] Organization organization)
        {
            if (ModelState.IsValid)
            {
                _context.Add(organization);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(organization);
        }

        // GET: Organizations/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var organization = await _context.Organizations.FindAsync(id);
            if (organization == null)
            {
                return NotFound();
            }
            return View(organization);
        }

        // POST: Organizations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Name,Address1,Address2,City,State,Zip,Phone,Email")] Organization organization)
        {
            if (id != organization.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(organization);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrganizationExists(organization.Id))
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
            return View(organization);
        }

        // GET: Organizations/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var organization = await _context.Organizations
                .FirstOrDefaultAsync(m => m.Id == id);
            if (organization == null)
            {
                return NotFound();
            }

            return View(organization);
        }

        // POST: Organizations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var organization = await _context.Organizations.FindAsync(id);
            _context.Organizations.Remove(organization);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrganizationExists(string id)
        {
            return _context.Organizations.Any(e => e.Id == id);
        }
    }
}
