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
    public class TipoGeneralsController : Controller
    {
        private readonly WebAppBibliotecaContext _context;

        public TipoGeneralsController(WebAppBibliotecaContext context)
        {
            _context = context;
        }

        // GET: TipoGenerals
        public async Task<IActionResult> Index()
        {
            return View(await _context.TipoGeneral.ToListAsync());
        }

        // GET: TipoGenerals/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoGeneral = await _context.TipoGeneral
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipoGeneral == null)
            {
                return NotFound();
            }

            return View(tipoGeneral);
        }

        // GET: TipoGenerals/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TipoGenerals/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Descripcion")] TipoGeneral tipoGeneral)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tipoGeneral);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tipoGeneral);
        }

        // GET: TipoGenerals/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoGeneral = await _context.TipoGeneral.FindAsync(id);
            if (tipoGeneral == null)
            {
                return NotFound();
            }
            return View(tipoGeneral);
        }

        // POST: TipoGenerals/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Descripcion")] TipoGeneral tipoGeneral)
        {
            if (id != tipoGeneral.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tipoGeneral);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipoGeneralExists(tipoGeneral.Id))
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
            return View(tipoGeneral);
        }

        // GET: TipoGenerals/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoGeneral = await _context.TipoGeneral
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipoGeneral == null)
            {
                return NotFound();
            }

            return View(tipoGeneral);
        }

        // POST: TipoGenerals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tipoGeneral = await _context.TipoGeneral.FindAsync(id);
            _context.TipoGeneral.Remove(tipoGeneral);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TipoGeneralExists(int id)
        {
            return _context.TipoGeneral.Any(e => e.Id == id);
        }
    }
}
