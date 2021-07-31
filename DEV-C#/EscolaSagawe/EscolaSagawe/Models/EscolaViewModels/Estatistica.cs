using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EscolaSagawe.Models.EscolaViewModels
{

    public class Estatistica // pagina Sobre, até eu mudar o nome.
    {
        [DataType(DataType.Date)]
        public DateTime? DataMatricula { get; set; }

        public int ContagemEstudante { get; set; }
    }
}
