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
    public class DetallesAlumnosMateriasController : Controller
    {
        private readonly InscripcionWebContext _context;

        public DetallesAlumnosMateriasController(InscripcionWebContext context)
        {
            _context = context;
        }

        // GET: DetallesAlumnosMaterias
        public async Task<IActionResult> Index()
        {
            var inscripcionWebContext = _context.DetallesAlumnosMaterias.Include(d => d.Alumno).Include(d => d.Materia);
            return View(await inscripcionWebContext.ToListAsync());
        }

        // GET: DetallesAlumnosMaterias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detalleAlumnoMateria = await _context.DetallesAlumnosMaterias
                .Include(d => d.Alumno)
                .Include(d => d.Materia)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (detalleAlumnoMateria == null)
            {
                return NotFound();
            }

            return View(detalleAlumnoMateria);
        }

        // GET: DetallesAlumnosMaterias/Create
        public IActionResult Create()
        {
            //ViewData["AlumnoId"] = new SelectList(_context.Alumnos, "Id", "Apellido");
            ViewData["AlumnoId"] = new SelectList(from alumno in _context.Alumnos.ToList() select new { Id = alumno.Id, Apellido = alumno.Apellido + " " + alumno.Nombre }, "Id", "Apellido");
            ViewData["MateriaId"] = new SelectList(_context.Materias, "Id", "Nombre");
            return View();
        }

        // POST: DetallesAlumnosMaterias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AlumnoId,MateriaId")] DetalleAlumnoMateria detalleAlumnoMateria)
        {
            if (ModelState.IsValid)
            {
                _context.Add(detalleAlumnoMateria);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AlumnoId"] = new SelectList(_context.Alumnos, "Id", "Apellido", detalleAlumnoMateria.AlumnoId);
            ViewData["MateriaId"] = new SelectList(_context.Materias, "Id", "Nombre", detalleAlumnoMateria.MateriaId);
            return View(detalleAlumnoMateria);
        }

        // GET: DetallesAlumnosMaterias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detalleAlumnoMateria = await _context.DetallesAlumnosMaterias.FindAsync(id);
            if (detalleAlumnoMateria == null)
            {
                return NotFound();
            }
            ViewData["AlumnoId"] = new SelectList(from alumno in _context.Alumnos.ToList() select new { Id = alumno.Id, Apellido = alumno.Apellido + " " + alumno.Nombre }, "Id", "Apellido");
            ViewData["MateriaId"] = new SelectList(_context.Materias, "Id", "Nombre", detalleAlumnoMateria.MateriaId);
            return View(detalleAlumnoMateria);
        }

        // POST: DetallesAlumnosMaterias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,AlumnoId,MateriaId")] DetalleAlumnoMateria detalleAlumnoMateria)
        {
            if (id != detalleAlumnoMateria.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(detalleAlumnoMateria);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DetalleAlumnoMateriaExists(detalleAlumnoMateria.Id))
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
            ViewData["AlumnoId"] = new SelectList(_context.Alumnos, "Id", "Apellido", detalleAlumnoMateria.AlumnoId);
            ViewData["MateriaId"] = new SelectList(_context.Materias, "Id", "Nombre", detalleAlumnoMateria.MateriaId);
            return View(detalleAlumnoMateria);
        }

        // GET: DetallesAlumnosMaterias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detalleAlumnoMateria = await _context.DetallesAlumnosMaterias
                .Include(d => d.Alumno)
                .Include(d => d.Materia)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (detalleAlumnoMateria == null)
            {
                return NotFound();
            }

            return View(detalleAlumnoMateria);
        }

        // POST: DetallesAlumnosMaterias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var detalleAlumnoMateria = await _context.DetallesAlumnosMaterias.FindAsync(id);
            _context.DetallesAlumnosMaterias.Remove(detalleAlumnoMateria);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DetalleAlumnoMateriaExists(int id)
        {
            return _context.DetallesAlumnosMaterias.Any(e => e.Id == id);
        }
    }
}
