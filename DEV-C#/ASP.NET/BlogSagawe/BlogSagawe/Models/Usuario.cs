using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSagawe.Models
{
    public class Usuario : IdentityUser
    {
        // itens extras do usuario
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

    }

    public class Regra : IdentityRole
    {
        public Regra() : base() { }
        public Regra(string name) : base(name) { }
        // propriedades extras
    }
}
