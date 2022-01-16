using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


// Model customizada do Usuário

/*https://codewithmukesh.com/blog/user-management-in-aspnet-core-mvc/
 * https://stackoverflow.com/questions/39146054/no-service-for-type-microsoft-aspnetcore-identity-signinmanager-when/52815698
 * Em _LoginPartial.cshtml foi alterado as inject, aplicação iniciou, mas deu erro nas página de login e registro
 * Em Register.cshtml.cs no parametro RegisterModel foi alterado do IdentityUser para ApplicationUser (em 4 pontos)
 * Foi preciso refazer o Scaffolding do arquivo _Layout.cshtml e adicionar em _ManageNav.cshtml o caminho das Model (local onde esta a classe do usuário)
 */
namespace ModuloGestãoUsuarios.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string NomeCompleto { 
            set
            {
                NomeCompleto = PrimeiroNome + " " + SobreNome;
            }
        }
        public string PrimeiroNome { get; set; }

        public string SobreNome { get; set; }

        public int LimiteTrocaNome { get; set; } = 10;

        public byte[] FotoPefil { get; set; }
    }
}
