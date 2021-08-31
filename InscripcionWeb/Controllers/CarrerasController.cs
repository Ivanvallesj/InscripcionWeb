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
    public class CarrerasController : Controller
    {
        private readonly InscripcionWebContext _context;

        public CarrerasController(InscripcionWebContext context)
        {
            _context = context;
        }

        // GET: Carreras
        public async Task<IActionResult> Index()
        {
            return View(await _context.Carreras.ToListAsync());
        }
        public async Task<IActionResult> IndexEliminadas()
        {
            return View(await _context.Carreras.IgnoreQueryFilters().Where(c=>c.Eliminado==true).ToListAsync());
        }

        // GET: Carreras/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carrera = await _context.Carreras
                .FirstOrDefaultAsync(m => m.Id == id);
            if (carrera == null)
            {
                return NotFound();
            }

            return View(carrera);
        }

        // GET: Carreras/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Carreras/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre")] Carrera carrera)
        {
            if (ModelState.IsValid)
            {
                _context.Add(carrera);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(carrera);
        }

        // GET: Carreras/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carrera = await _context.Carreras.FindAsync(id);
            if (carrera == null)
            {
                return NotFound();
            }
            return View(carrera);
        }

        // POST: Carreras/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre")] Carrera carrera)
        {
            if (id != carrera.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(carrera);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarreraExists(carrera.Id))
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
            return View(carrera);
        }

        // GET: Carreras/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carrera = await _context.Carreras
                .FirstOrDefaultAsync(m => m.Id == id);
            if (carrera == null)
            {
                return NotFound();
            }

            return View(carrera);
        }
        // GET: Carreras/Eliminacion definitiva/5
        public async Task<IActionResult> Eliminaciondefinitiva(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carrera = await _context.Carreras.IgnoreQueryFilters()
                .FirstOrDefaultAsync(m => m.Id == id);
            if (carrera == null)
            {
                return NotFound();
            }

            return View(carrera);
        }
        // GET: Carreras/Restaurar/5
        public async Task<IActionResult> Restaurar(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carrera = await _context.Carreras.IgnoreQueryFilters()
                .FirstOrDefaultAsync(m => m.Id == id);
            if (carrera == null)
            {
                return NotFound();
            }
            return View(carrera);
        }
        // POST: Carreras/Eliminacion definitiva/5
        [HttpPost, ActionName("Restaurar")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RestauracionConfirmada(int id)
        {
            var carrera = await _context.Carreras.IgnoreQueryFilters().FirstOrDefaultAsync(c => c.Id == id);
            //agregamos esta linea que pone el campo eliminado en verdadero 
            carrera.Eliminado = false;
            //_context.Carreras.Remove(carrera);
            _context.Update(carrera);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // POST: Carreras/Restaurar/5
        [HttpPost, ActionName("Eliminaciondefinitiva")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Eliminaciondefinitiva(int id)
        {
            var carrera = await _context.Carreras.IgnoreQueryFilters().FirstOrDefaultAsync(c => c.Id == id); 
            _context.Carreras.Remove(carrera);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(IndexEliminadas));
        }

        // POST: Carreras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var carrera = await _context.Carreras.FindAsync(id);
            //agregamos esta linea que pone el campo eliminado en verdadero 
            carrera.Eliminado = true;
            //_context.Carreras.Remove(carrera);
            _context.Update(carrera);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CarreraExists(int id)
        {
            return _context.Carreras.Any(e => e.Id == id);
        }
    }
}
