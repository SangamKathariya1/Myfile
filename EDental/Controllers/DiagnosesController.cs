using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EDental.Data;
using EDental.Data.Models;

namespace EDental.Controllers
{
    public class DiagnosesController : Controller
    {
        private readonly EDentalDbContext _context;

        public DiagnosesController(EDentalDbContext context)
        {
            _context = context;
        }

        // GET: Diagnoses
        public async Task<IActionResult> Index()
        {
            return View(await _context.Diagnoses.ToListAsync());
        }

        // GET: Diagnoses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diagnoses = await _context.Diagnoses
                .FirstOrDefaultAsync(m => m.Id == id);
            if (diagnoses == null)
            {
                return NotFound();
            }

            return View(diagnoses);
        }

        // GET: Diagnoses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Diagnoses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Procedures,Medication")] Diagnosis diagnoses)
        {
            if (ModelState.IsValid)
            {
                _context.Add(diagnoses);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(diagnoses);
        }

        // GET: Diagnoses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diagnoses = await _context.Diagnoses.FindAsync(id);
            if (diagnoses == null)
            {
                return NotFound();
            }
            return View(diagnoses);
        }

        // POST: Diagnoses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Procedures,Medication")] Diagnosis diagnoses)
        {
            if (id != diagnoses.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(diagnoses);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DiagnosesExists(diagnoses.Id))
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
            return View(diagnoses);
        }

        // GET: Diagnoses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diagnoses = await _context.Diagnoses
                .FirstOrDefaultAsync(m => m.Id == id);
            if (diagnoses == null)
            {
                return NotFound();
            }

            return View(diagnoses);
        }

        // POST: Diagnoses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var diagnoses = await _context.Diagnoses.FindAsync(id);
            if (diagnoses != null)
            {
                _context.Diagnoses.Remove(diagnoses);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DiagnosesExists(int id)
        {
            return _context.Diagnoses.Any(e => e.Id == id);
        }
    }
}
