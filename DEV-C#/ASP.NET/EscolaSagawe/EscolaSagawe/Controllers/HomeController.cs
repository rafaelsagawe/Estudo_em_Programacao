using Microsoft.EntityFrameworkCore;
using EscolaSagawe.Models.EscolaViewModels;
using EscolaSagawe.Data;
using EscolaSagawe.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EscolaSagawe.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly EscolaContext _context;

        public HomeController(ILogger<HomeController> logger, EscolaContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public async Task<ActionResult> Sobre()
        {
            IQueryable<Estatistica> data =
                                           from Estudante in _context.Estudantes
                                           group Estudante by Estudante.DataMatricula into dateGroup
                                           select new Estatistica()
                                           {
                                               DataMatricula = dateGroup.Key,
                                               ContagemEstudante = dateGroup.Count()
                                           };
            return View(await data.AsNoTracking().ToListAsync());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
