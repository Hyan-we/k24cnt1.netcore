using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NhaLesson10EFDbFirst.Models;

namespace NhaLesson10EFDbFirst.Controllers
{
    public class NhaMembersController : Controller
    {
        private readonly NhaLesson10EfdbContext _context;

        public NhaMembersController(NhaLesson10EfdbContext context)
        {
            _context = context;
        }

        // GET: NhaMembers
        public async Task<IActionResult> Index()
        {
            return View(await _context.NhaMembers.ToListAsync());
        }

        // GET: NhaMembers/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nhaMember = await _context.NhaMembers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (nhaMember == null)
            {
                return NotFound();
            }

            return View(nhaMember);
        }

        // GET: NhaMembers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NhaMembers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NhaUserName,NhaPassword,NhaFullName,NhaEmail,NhaPhone,NhaStatus")] NhaMember nhaMember)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nhaMember);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nhaMember);
        }

        // GET: NhaMembers/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nhaMember = await _context.NhaMembers.FindAsync(id);
            if (nhaMember == null)
            {
                return NotFound();
            }
            return View(nhaMember);
        }

        // POST: NhaMembers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,NhaUserName,NhaPassword,NhaFullName,NhaEmail,NhaPhone,NhaStatus")] NhaMember nhaMember)
        {
            if (id != nhaMember.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nhaMember);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NhaMemberExists(nhaMember.Id))
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
            return View(nhaMember);
        }

        // GET: NhaMembers/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nhaMember = await _context.NhaMembers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (nhaMember == null)
            {
                return NotFound();
            }

            return View(nhaMember);
        }

        // POST: NhaMembers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var nhaMember = await _context.NhaMembers.FindAsync(id);
            if (nhaMember != null)
            {
                _context.NhaMembers.Remove(nhaMember);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NhaMemberExists(long id)
        {
            return _context.NhaMembers.Any(e => e.Id == id);
        }
    }
}
