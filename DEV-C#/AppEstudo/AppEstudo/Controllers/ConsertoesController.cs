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
    public class ConsertoesController : Controller
    {
        private readonly AppEstudoContext _context;

        public ConsertoesController(AppEstudoContext context)
        {
            _context = context;
        }

        // GET: Consertoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Conserto.ToListAsync());
        }

        // GET: Consertoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var conserto = await _context.Conserto
                .FirstOrDefaultAsync(m => m.Id == id);
            if (conserto == null)
            {
                return NotFound();
            }

            return View(conserto);
        }

        // GET: Consertoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Consertoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DataEntrada,NomeCliente,NomeFuncionario,NomePeca,DescricaoDefeito,DescricaoSolucao,ValorMaoObra,ValorTotalConserto")] Conserto conserto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(conserto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(conserto);
        }

        // GET: Consertoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var conserto = await _context.Conserto.FindAsync(id);
            if (conserto == null)
            {
                return NotFound();
            }
            return View(conserto);
        }

        // POST: Consertoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DataEntrada,NomeCliente,NomeFuncionario,NomePeca,DescricaoDefeito,DescricaoSolucao,ValorMaoObra,ValorTotalConserto")] Conserto conserto)
        {
            if (id != conserto.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(conserto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ConsertoExists(conserto.Id))
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
            return View(conserto);
        }

        // GET: Consertoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var conserto = await _context.Conserto
                .FirstOrDefaultAsync(m => m.Id == id);
            if (conserto == null)
            {
                return NotFound();
            }

            return View(conserto);
        }

        // POST: Consertoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var conserto = await _context.Conserto.FindAsync(id);
            _context.Conserto.Remove(conserto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ConsertoExists(int id)
        {
            return _context.Conserto.Any(e => e.Id == id);
        }
    }
}
