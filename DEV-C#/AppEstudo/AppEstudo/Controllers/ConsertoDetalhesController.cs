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
    public class ConsertoDetalhesController : Controller
    {
        private readonly AppEstudoContext _context;

        public ConsertoDetalhesController(AppEstudoContext context)
        {
            _context = context;
        }

        // GET: ConsertoDetalhes
        public async Task<IActionResult> Index()
        {
            var appEstudoContext = _context.ConsertoDetalhes.Include(c => c.Conserto);
            return View(await appEstudoContext.ToListAsync());
        }

        // GET: ConsertoDetalhes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consertoDetalhes = await _context.ConsertoDetalhes
                .Include(c => c.Conserto)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (consertoDetalhes == null)
            {
                return NotFound();
            }

            return View(consertoDetalhes);
        }

        // GET: ConsertoDetalhes/Create
        public IActionResult Create()
        {
            ViewData["ConsertoId"] = new SelectList(_context.Conserto, "Id", "Id");
            return View();
        }

        // POST: ConsertoDetalhes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ConsertoId,PecasId,Total")] ConsertoDetalhes consertoDetalhes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(consertoDetalhes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["NomeCliente"] = new SelectList(_context.Conserto, "NomeCliente", "NomeCliente", consertoDetalhes.NomeCliente);
            return View(consertoDetalhes);
        }

        // GET: ConsertoDetalhes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consertoDetalhes = await _context.ConsertoDetalhes.FindAsync(id);
            if (consertoDetalhes == null)
            {
                return NotFound();
            }
            ViewData["ConsertoId"] = new SelectList(_context.Conserto, "NomeCliente", "Id", consertoDetalhes);
            return View(consertoDetalhes);
        }

        // POST: ConsertoDetalhes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ConsertoId,PecasId,Total")] ConsertoDetalhes consertoDetalhes)
        {
            if (id != consertoDetalhes.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(consertoDetalhes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ConsertoDetalhesExists(consertoDetalhes.Id))
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
            ViewData["ConsertoId"] = new SelectList(_context.Conserto, "NomeCliente", "Id", consertoDetalhes);
            return View(consertoDetalhes);
        }

        // GET: ConsertoDetalhes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consertoDetalhes = await _context.ConsertoDetalhes
                .Include(c => c.Conserto)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (consertoDetalhes == null)
            {
                return NotFound();
            }

            return View(consertoDetalhes);
        }

        // POST: ConsertoDetalhes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var consertoDetalhes = await _context.ConsertoDetalhes.FindAsync(id);
            _context.ConsertoDetalhes.Remove(consertoDetalhes);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ConsertoDetalhesExists(int id)
        {
            return _context.ConsertoDetalhes.Any(e => e.Id == id);
        }
    }
}
