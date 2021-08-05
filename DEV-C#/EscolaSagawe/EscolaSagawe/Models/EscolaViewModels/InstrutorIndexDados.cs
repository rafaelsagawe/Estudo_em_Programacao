using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscolaSagawe.Models.EscolaViewModels
{
    public class InstrutorIndexDados
    {
        public IEnumerable<Instrutor> Instrutors { get; set; }
        public IEnumerable<Curso> Cursos { get; set; }
        public IEnumerable<Matricula> Matriculas { get; set; }
    }
}
