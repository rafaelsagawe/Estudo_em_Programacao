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

        private void PopularDepartamentoDropDownList(object selecaoDepartamento = null)
        {
            // Metodo respansavel por obter a listagem de departamentos para a criação da coleção/Seleção selecaoDepartamento, por fim lança esta coleção na ViewBag para utilização nas View

            var consultaDepartamento = from d in _context.Departamentos
                                       orderby d.Nome // Realiza a ordenação 
                                       select d;
            ViewBag.DepartamentoID = new SelectList(consultaDepartamento.AsNoTracking(), "DepartamentoID", "Nome", selecaoDepartamento);
        }

        // Montagem da pagina Index
        public async Task<IActionResult> Index()
        {
            var cursos = _context.Cursos
                .Include(c => c.Departamento)
                .AsNoTracking();
            return View(await cursos.ToArrayAsync());
        }

        // Montagem da pagina Detalhes
        // ToDo Adição do model Deparatamento na estrutura do curso

        // Montagem da pagina Adicionar
        public IActionResult Create()
        {
            /* Conteudo original
             * ViewData["DepartamentoID"] = new SelectList(_context.Departamentos, "DepartamentoID", "DepartamentoID");
             */
            PopularDepartamentoDropDownList();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CursoID,Titulo,Notas,DepartamentoID")] Curso curso)
        {
            /* Conteudo original
             if (ModelState.IsValid)
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





        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var curso = await _context.Cursos
                .Include(c => c.Departamento) 
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.CursoID == id);
            if (curso == null)
            {
                return NotFound();
            }

            return View(curso);
        }

       
        // Montagem da pagina Editar 
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

            /* Conteudo original
            var curso = await _context.Cursos.FindAsync(id);
            if (curso == null)
            {
                return NotFound();
            }
            ViewData["DepartamentoID"] = new SelectList(_context.Departamentos, "DepartamentoID", "DepartamentoID", curso.DepartamentoID);
            return View(curso);*/

        }

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

            /* Conteudo original 
             if (id != curso.CursoID)
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



        // GET: Cursos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var curso = await _context.Cursos
                .Include(c => c.Departamento)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.CursoID == id);
            if (curso == null)
            {
                return NotFound();
            }

            return View(curso);
        }

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
