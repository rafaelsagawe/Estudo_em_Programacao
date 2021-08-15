using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using BlogCoreCodeFist.Models;

namespace BlogCoreCodeFist.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<BlogCoreCodeFist.Models.Categorias> Categorias { get; set; }
        public DbSet<BlogCoreCodeFist.Models.Posts> Posts { get; set; }
    }
}
