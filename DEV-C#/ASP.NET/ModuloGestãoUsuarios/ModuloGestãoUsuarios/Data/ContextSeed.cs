using Microsoft.AspNetCore.Identity;
using ModuloGestãoUsuarios.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModuloGestãoUsuarios.Data
{
    public static class ContextSeed
    {
        public static async Task SeedRegrasAsync (UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            //Semear Regras
            await roleManager.CreateAsync(new IdentityRole(Enums.Regras.SuperAdmin.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Enums.Regras.Admin.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Enums.Regras.Moderador.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Enums.Regras.Basico.ToString()));
        }
    }
}
