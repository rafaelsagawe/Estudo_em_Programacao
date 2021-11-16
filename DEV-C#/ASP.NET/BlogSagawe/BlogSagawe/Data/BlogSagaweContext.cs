using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlogSagawe.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace BlogSagawe.Data
{
    public class BlogSagaweContext : IdentityDbContext<Usuario>
    {
        public BlogSagaweContext (DbContextOptions<BlogSagaweContext> options)
            : base(options)
        {
        }

        public DbSet<BlogSagawe.Models.Categorias> Categorias { get; set; }

        public DbSet<BlogSagawe.Models.Posts> Posts { get; set; }
    }
}
