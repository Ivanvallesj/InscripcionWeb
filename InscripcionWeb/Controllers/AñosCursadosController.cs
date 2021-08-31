using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using InscripcionWeb.Data;
using InscripcionWeb.Models;

namespace InscripcionWeb.Controllers
{
    public class AñosCursadosController : Controller
    {
        private readonly InscripcionWebContext _context;

        public AñosCursadosController(InscripcionWebContext context)
        {
            _context = context;
        }

        // GET: AñosCursados
        public async Task<IActionResult> Index()
        {
            var inscripcionWebContext = _context.AñoCursados.Include(a => a.Carrera);
            return View(await inscripcionWebContext.ToListAsync());
        }
        public async Task<IActionResult> IndexEliminadas()
        {
            return View(await _context.AñoCursados.IgnoreQueryFilters().Where(c => c.Eliminado == true).ToListAsync());
        }

        // GET: AñosCursados/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var añoCursado = await _context.AñoCursados
                .Include(a => a.Carrera)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (añoCursado == null)
            {
                return NotFound();
            }

            return View(añoCursado);
        }

        // GET: AñosCursados/Create
        public IActionResult Create()
        {
            ViewData["CarreraId"] = new SelectList(_context.Carreras, "Id", "Nombre");
            return View();
        }

        // POST: AñosCursados/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,CarreraId")] AñoCursado añoCursado)
        {
            if (ModelState.IsValid)
            {
                _context.Add(añoCursado);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CarreraId"] = new SelectList(_context.Carreras, "Id", "Nombre", añoCursado.CarreraId);
            return View(añoCursado);
        }

        // GET: AñosCursados/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var añoCursado = await _context.AñoCursados.FindAsync(id);
            if (añoCursado == null)
            {
                return NotFound();
            }
            ViewData["CarreraId"] = new SelectList(_context.Carreras, "Id", "Nombre", añoCursado.CarreraId);
            return View(añoCursado);
        }

        // POST: AñosCursados/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,CarreraId")] AñoCursado añoCursado)
        {
            if (id != añoCursado.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(añoCursado);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AñoCursadoExists(añoCursado.Id))
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
            ViewData["CarreraId"] = new SelectList(_context.Carreras, "Id", "Nombre", añoCursado.CarreraId);
            return View(añoCursado);
        }

        // GET: AñosCursados/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var añoCursado = await _context.AñoCursados
                .Include(a => a.Carrera)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (añoCursado == null)
            {
                return NotFound();
            }

            return View(añoCursado);
        }

        // POST: AñosCursados/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var añoCursado = await _context.AñoCursados.FindAsync(id);
            _context.AñoCursados.Remove(añoCursado);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AñoCursadoExists(int id)
        {
            return _context.AñoCursados.Any(e => e.Id == id);
        }
        // GET: años cursados/Eliminacion definitiva/5
        public async Task<IActionResult> Eliminaciondefinitiva(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var añoCursado = await _context.AñoCursados.IgnoreQueryFilters()
                .FirstOrDefaultAsync(m => m.Id == id);
            if (añoCursado == null)
            {
                return NotFound();
            }

            return View(añoCursado);
        }
        // POST: años cursados/Eliminacion definitiva/5
        [HttpPost, ActionName("Restaurar")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RestauracionConfirmada(int id)
        {
            var añoCursado = await _context.AñoCursados.IgnoreQueryFilters().FirstOrDefaultAsync(c => c.Id == id);
            //agregamos esta linea que pone el campo eliminado en verdadero 
            añoCursado.Eliminado = false;
            //_context.Alumnos.Remove(carrera);
            _context.Update(añoCursado);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        // GET: años cursados/Restaurar/5
        public async Task<IActionResult> Restaurar(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var añoCursado = await _context.AñoCursados.IgnoreQueryFilters()
                .FirstOrDefaultAsync(m => m.Id == id);
            if (añoCursado == null)
            {
                return NotFound();
            }
            return View(añoCursado);
        }
        // POST: años cursados/Restaurar/5
        [HttpPost, ActionName("Eliminaciondefinitiva")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Eliminaciondefinitiva(int id)
        {
            var añoCursado = await _context.AñoCursados.IgnoreQueryFilters().FirstOrDefaultAsync(c => c.Id == id);
            _context.AñoCursados.Remove(añoCursado);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(IndexEliminadas));
        }
    }
}
