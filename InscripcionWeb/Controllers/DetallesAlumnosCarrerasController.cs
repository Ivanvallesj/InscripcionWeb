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
    public class DetallesAlumnosCarrerasController : Controller
    {
        private readonly InscripcionWebContext _context;

        public DetallesAlumnosCarrerasController(InscripcionWebContext context)
        {
            _context = context;
        }

        // GET: DetallesAlumnosCarreras
        public async Task<IActionResult> Index()
        {
            var inscripcionWebContext = _context.DetallesAlumnosCarreras.Include(d => d.Alumno).Include(d => d.Carrera);
            return View(await inscripcionWebContext.ToListAsync());
        }

        // GET: DetallesAlumnosCarreras/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detalleAlumnoCarrera = await _context.DetallesAlumnosCarreras
                .Include(d => d.Alumno)
                .Include(d => d.Carrera)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (detalleAlumnoCarrera == null)
            {
                return NotFound();
            }

            return View(detalleAlumnoCarrera);
        }

        // GET: DetallesAlumnosCarreras/Create
        public IActionResult Create()
        {
            //ViewData["AlumnoId"] = new SelectList(_context.Alumnos, "Id", "Apellido");
            ViewData["AlumnoId"] = new SelectList(from alumno in _context.Alumnos.ToList() select new { Id = alumno.Id, Apellido = alumno.Apellido + " " + alumno.Nombre }, "Id", "Apellido");
            ViewData["CarreraId"] = new SelectList(_context.Carreras, "Id", "Nombre");
            return View();
        }

        // POST: DetallesAlumnosCarreras/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AlumnoId,CarreraId")] DetalleAlumnoCarrera detalleAlumnoCarrera)
        {
            if (ModelState.IsValid)
            {
                _context.Add(detalleAlumnoCarrera);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AlumnoId"] = new SelectList(_context.Alumnos, "Id", "Apellido", detalleAlumnoCarrera.AlumnoId);
            ViewData["CarreraId"] = new SelectList(_context.Carreras, "Id", "Nombre", detalleAlumnoCarrera.CarreraId);
            return View(detalleAlumnoCarrera);
        }

        // GET: DetallesAlumnosCarreras/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detalleAlumnoCarrera = await _context.DetallesAlumnosCarreras.FindAsync(id);
            if (detalleAlumnoCarrera == null)
            {
                return NotFound();
            }
            ViewData["AlumnoId"] = new SelectList(from alumno in _context.Alumnos.ToList() select new { Id = alumno.Id, Apellido = alumno.Apellido + " " + alumno.Nombre }, "Id", "Apellido");
            ViewData["CarreraId"] = new SelectList(_context.Carreras, "Id", "Nombre", detalleAlumnoCarrera.CarreraId);
            return View(detalleAlumnoCarrera);
        }

        // POST: DetallesAlumnosCarreras/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,AlumnoId,CarreraId")] DetalleAlumnoCarrera detalleAlumnoCarrera)
        {
            if (id != detalleAlumnoCarrera.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(detalleAlumnoCarrera);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DetalleAlumnoCarreraExists(detalleAlumnoCarrera.Id))
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
            ViewData["AlumnoId"] = new SelectList(_context.Alumnos, "Id", "Apellido", detalleAlumnoCarrera.AlumnoId);
            ViewData["CarreraId"] = new SelectList(_context.Carreras, "Id", "Nombre", detalleAlumnoCarrera.CarreraId);
            return View(detalleAlumnoCarrera);
        }

        // GET: DetallesAlumnosCarreras/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detalleAlumnoCarrera = await _context.DetallesAlumnosCarreras
                .Include(d => d.Alumno)
                .Include(d => d.Carrera)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (detalleAlumnoCarrera == null)
            {
                return NotFound();
            }

            return View(detalleAlumnoCarrera);
        }

        // POST: DetallesAlumnosCarreras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var detalleAlumnoCarrera = await _context.DetallesAlumnosCarreras.FindAsync(id);
            _context.DetallesAlumnosCarreras.Remove(detalleAlumnoCarrera);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DetalleAlumnoCarreraExists(int id)
        {
            return _context.DetallesAlumnosCarreras.Any(e => e.Id == id);
        }
    }
}
