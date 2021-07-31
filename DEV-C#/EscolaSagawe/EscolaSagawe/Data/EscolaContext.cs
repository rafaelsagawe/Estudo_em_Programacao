using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EscolaSagawe.Models;
using Microsoft.EntityFrameworkCore;

namespace EscolaSagawe.Data
{
    public class EscolaContext : DbContext
    {
        public EscolaContext(DbContextOptions<EscolaContext> options) : base(options)
    {
    }

        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Matricula> Matriculas { get; set; }

        public DbSet<Estudante> Estudantes { get; set; }
    }
}
