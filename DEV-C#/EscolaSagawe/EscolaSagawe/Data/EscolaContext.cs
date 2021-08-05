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
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Instrutor> Instrutors { get; set; }
        public DbSet<Sala> Salas { get; set; }
        public DbSet<CursoAdministrado> cursoAdministrados { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CursoAdministrado>()
                .HasKey(c => new { c.CursoID, c.InstrutorID });
        }

        /*
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Curso>().ToTable(nameof(Curso))
                .HasMany(c => c.Instrutors)
                .WithMany(i => i.Cursos);
            modelBuilder.Entity<Estudante>().ToTable(nameof(Estudante));
            modelBuilder.Entity<Instrutor>().ToTable(nameof(Instrutor));
        }
        */
    }
}
