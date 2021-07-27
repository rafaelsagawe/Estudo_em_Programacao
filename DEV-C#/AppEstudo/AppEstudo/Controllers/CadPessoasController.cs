using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AppEstudo.Data;
using AppEstudo.Models;

namespace AppEstudo.Controllers
{
    public class CadPessoasController : Controller
    {
        private readonly AppEstudoContext _context;

        public CadPessoasController(AppEstudoContext context)
        {
            _context = context;
        }

        // GET: CadPessoas
        public async Task<IActionResult> Index()
        {
            return View(await _context.CadPessoa.ToListAsync());
        }

        // GET: CadPessoas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cadPessoa = await _context.CadPessoa
                .FirstOrDefaultAsync(m => m.IdPessoa == id);
            if (cadPessoa == null)
            {
                return NotFound();
            }

            return View(cadPessoa);
        }

        // GET: CadPessoas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CadPessoas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdPessoa,NomePrimeiro,SubreNome,DataNascimento")] CadPessoa cadPessoa)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cadPessoa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cadPessoa);
        }

        // GET: CadPessoas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cadPessoa = await _context.CadPessoa.FindAsync(id);
            if (cadPessoa == null)
            {
                return NotFound();
            }
            return View(cadPessoa);
        }

        // POST: CadPessoas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdPessoa,NomePrimeiro,SubreNome,DataNascimento")] CadPessoa cadPessoa)
        {
            if (id != cadPessoa.IdPessoa)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cadPessoa);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CadPessoaExists(cadPessoa.IdPessoa))
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
            return View(cadPessoa);
        }

        // GET: CadPessoas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cadPessoa = await _context.CadPessoa
                .FirstOrDefaultAsync(m => m.IdPessoa == id);
            if (cadPessoa == null)
            {
                return NotFound();
            }

            return View(cadPessoa);
        }

        // POST: CadPessoas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cadPessoa = await _context.CadPessoa.FindAsync(id);
            _context.CadPessoa.Remove(cadPessoa);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CadPessoaExists(int id)
        {
            return _context.CadPessoa.Any(e => e.IdPessoa == id);
        }
    }
}
