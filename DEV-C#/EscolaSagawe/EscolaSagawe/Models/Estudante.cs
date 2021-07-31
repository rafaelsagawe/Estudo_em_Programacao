using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace EscolaSagawe.Models
{
    public class Estudante
    {
        public int ID { get; set; }
        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public DateTime DataMatricula { get; set; }

        public ICollection<Matricula> Matriculas { get; set; }
    }
}
