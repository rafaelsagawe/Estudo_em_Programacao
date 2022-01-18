using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModuloGestãoUsuarios.Models
{
    public class UsuarioRegraViewModel
    {

        public string UserId { get; set; }
        public string PrimeiroNome { get; set; }
        public string Sobrenome { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public IEnumerable<string> Regra { get; set; }
    }
}
