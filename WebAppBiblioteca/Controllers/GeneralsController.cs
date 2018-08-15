using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebAppBiblioteca.Models;

namespace WebAppBiblioteca.Controllers
{
    public class GeneralsController : Controller
    {
        private readonly WebAppBibliotecaContext _context;

        public GeneralsController(WebAppBibliotecaContext context)
        {
            _context = context;
        }

        // GET: Generals
        public async Task<IActionResult> Index()
        {
            return View(await _context.General.ToListAsync());
        }

        // GET: Generals/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var general = await _context.General
                .FirstOrDefaultAsync(m => m.Id == id);
            if (general == null)
            {
                return NotFound();
            }

            return View(general);
        }

        // GET: Generals/Create
        public IActionResult Create()
        {
            ViewData["TipoGeneralId"] = new SelectList(_context.TipoGeneral, "Id", "Nombre");
            
            return View();
        }

        // POST: Generals/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Descripcion,TipoGeneralId")] General general)
        {
            if (ModelState.IsValid)
            {
                _context.Add(general);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(general);
        }

        // GET: Generals/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var general = await _context.General.FindAsync(id);
            if (general == null)
            {
                return NotFound();
            }
            return View(general);
        }

        // POST: Generals/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Descripcion")] General general)
        {
            if (id != general.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(general);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GeneralExists(general.Id))
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
            return View(general);
        }

        // GET: Generals/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var general = await _context.General
                .FirstOrDefaultAsync(m => m.Id == id);
            if (general == null)
            {
                return NotFound();
            }

            return View(general);
        }

        // POST: Generals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var general = await _context.General.FindAsync(id);
            _context.General.Remove(general);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GeneralExists(int id)
        {
            return _context.General.Any(e => e.Id == id);
        }
    }
}
