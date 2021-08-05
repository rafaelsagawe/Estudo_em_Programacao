using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EscolaSagawe.Data;
using EscolaSagawe.Models;
using EscolaSagawe.Models.EscolaViewModels;

namespace EscolaSagawe.Controllers
{
    public class InstrutorsController : Controller
    {
        private readonly EscolaContext _context;

        public InstrutorsController(EscolaContext context)
        {
            _context = context;
        }

        // GET: Instrutors
        /* Original
        public async Task<IActionResult> Index()
        {
            return View(await _context.Instrutors.ToListAsync());
        }
        */
        public async Task<IActionResult> Index(int? id, int? CursoID)
        {
            var viewModel = new InstrutorIndexDados();
            viewModel.Instrutors = await _context.Instrutors
                  .Include(i => i.Sala)
                  .Include(i => i.CursoAdministrados)
                    .ThenInclude(i => i.Curso)
                        .ThenInclude(i => i.Matriculas)
                            .ThenInclude(i => i.Estudante)
                  .Include(i => i.CursoAdministrados)
                    .ThenInclude(i => i.Curso)
                        .ThenInclude(i => i.Departamento)
                  .AsNoTracking()
                  .OrderBy(i => i.Nome)
                  .ToListAsync();

            if (id != null)
            {
                ViewData["InstrutorID"] = id.Value;
                Instrutor instrutor = viewModel.Instrutors.Where(
                    i => i.ID == id.Value).Single();
                viewModel.Cursos = instrutor.CursoAdministrados.Select(s => s.Curso);
            }

            if (CursoID != null)
            {
                ViewData["CursoID"] = CursoID.Value;
                viewModel.Matriculas = viewModel.Cursos.Where(
                    x => x.CursoID == CursoID).Single().Matriculas;
            }

            return View(viewModel);
        }


        // GET: Instrutors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var instrutor = await _context.Instrutors
                .FirstOrDefaultAsync(m => m.ID == id);
            if (instrutor == null)
            {
                return NotFound();
            }

            return View(instrutor);
        }

        // GET: Instrutors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Instrutors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Nome,SobreNome,DataAdmicacao")] Instrutor instrutor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(instrutor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(instrutor);
        }

        // GET: Instrutors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var instrutor = await _context.Instrutors.FindAsync(id);
            if (instrutor == null)
            {
                return NotFound();
            }
            return View(instrutor);
        }

        // POST: Instrutors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Nome,SobreNome,DataAdmicacao")] Instrutor instrutor)
        {
            if (id != instrutor.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(instrutor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InstrutorExists(instrutor.ID))
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
            return View(instrutor);
        }

        // GET: Instrutors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var instrutor = await _context.Instrutors
                .FirstOrDefaultAsync(m => m.ID == id);
            if (instrutor == null)
            {
                return NotFound();
            }

            return View(instrutor);
        }

        // POST: Instrutors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var instrutor = await _context.Instrutors.FindAsync(id);
            _context.Instrutors.Remove(instrutor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InstrutorExists(int id)
        {
            return _context.Instrutors.Any(e => e.ID == id);
        }
    }
}
