using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EscolaSagawe.Data;
using EscolaSagawe.Models;

namespace EscolaSagawe.Controllers
{
    public class CursosController : Controller
    {
        private readonly EscolaContext _context;

        public CursosController(EscolaContext context)
        {
            _context = context;
        }

        // GET: Cursos
        /* Original
        public async Task<IActionResult> Index()
        {
            var escolaContext = _context.Cursos.Include(c => c.Departamento);
            return View(await escolaContext.ToListAsync());
        }
        */

        public async Task<IActionResult> Index()
        {
            var cursos = _context.Cursos
                .Include(c => c.Departamento)
                .AsNoTracking();
            return View(await cursos.ToArrayAsync());
        }


        // GET: Cursos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var curso = await _context.Cursos
                .Include(c => c.Departamento)
                .FirstOrDefaultAsync(m => m.CursoID == id);
            if (curso == null)
            {
                return NotFound();
            }

            return View(curso);
        }

        // GET: Cursos/Create
        public IActionResult Create()
        {
            //ViewData["DepartamentoID"] = new SelectList(_context.Departamentos, "DepartamentoID", "DepartamentoID");
            PopularDepartamentoDropDownList();
            return View();
        }

        // POST: Cursos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CursoID,Titulo,Notas,DepartamentoID")] Curso curso)
        {
            /* if (ModelState.IsValid)
             {
                 _context.Add(curso);
                 await _context.SaveChangesAsync();
                 return RedirectToAction(nameof(Index));
             }

             ViewData["DepartamentoID"] = new SelectList(_context.Departamentos, "DepartamentoID", "DepartamentoID", curso.DepartamentoID);
             return View(curso);
            */
            if (ModelState.IsValid)
            {
                _context.Add(curso);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            PopularDepartamentoDropDownList(curso.DepartamentoID);
            return View(curso);

        }

        // GET: Cursos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var curso = await _context.Cursos
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.CursoID == id);
            if (curso == null)
            {
                return NotFound();
            }
            PopularDepartamentoDropDownList(curso.DepartamentoID);
            return View(curso);

            /*
            var curso = await _context.Cursos.FindAsync(id);
            if (curso == null)
            {
                return NotFound();
            }
            ViewData["DepartamentoID"] = new SelectList(_context.Departamentos, "DepartamentoID", "DepartamentoID", curso.DepartamentoID);
            return View(curso);*/

        }

        // POST: Cursos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CursoID,Titulo,Notas,DepartamentoID")] Curso curso)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cursoParaAtualizar = await _context.Cursos
                .FirstOrDefaultAsync(c => c.CursoID == id);

            if (await TryUpdateModelAsync<Curso>(cursoParaAtualizar,
                "",
                c => c.Notas, c => c.DepartamentoID, c => c.Titulo))
            {
                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateException /* ex */)
                {
                    //Log the error (uncomment ex variable name and write a log.)
                    ModelState.AddModelError("", "Unable to save changes. " +
                        "Try again, and if the problem persists, " +
                        "see your system administrator.");
                }
                return RedirectToAction(nameof(Index));
            }
            PopularDepartamentoDropDownList(cursoParaAtualizar.DepartamentoID);
            return View(cursoParaAtualizar);

            /* if (id != curso.CursoID)
             {
                 return NotFound();
             }

             if (ModelState.IsValid)
             {
                 try
                 {
                     _context.Update(curso);
                     await _context.SaveChangesAsync();
                 }
                 catch (DbUpdateConcurrencyException)
                 {
                     if (!CursoExists(curso.CursoID))
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
             ViewData["DepartamentoID"] = new SelectList(_context.Departamentos, "DepartamentoID", "DepartamentoID", curso.DepartamentoID);
             return View(curso);*/
        }

        private void PopularDepartamentoDropDownList(object selecaoDepartamento = null)
        {
            var consultaDepartamento = from d in _context.Departamentos
                                       orderby d.Nome
                                       select d;
            ViewBag.DepartamentoID = new SelectList(consultaDepartamento.AsNoTracking(), "DepartamentoID", "Nome", selecaoDepartamento);
        }

        // GET: Cursos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var curso = await _context.Cursos
                .Include(c => c.Departamento)
                .FirstOrDefaultAsync(m => m.CursoID == id);
            if (curso == null)
            {
                return NotFound();
            }

            return View(curso);
        }

        // POST: Cursos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var curso = await _context.Cursos.FindAsync(id);
            _context.Cursos.Remove(curso);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CursoExists(int id)
        {
            return _context.Cursos.Any(e => e.CursoID == id);
        }
    }
}
