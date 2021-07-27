using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AppEstudo.Models;

namespace AppEstudo.Data
{
    public class AppEstudoContext : DbContext
    {
        public AppEstudoContext (DbContextOptions<AppEstudoContext> options)
            : base(options)
        {
        }

        public DbSet<AppEstudo.Models.CadPessoa> CadPessoa { get; set; }
    }
}
