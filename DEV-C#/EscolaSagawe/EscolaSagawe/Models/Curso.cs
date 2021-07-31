using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EscolaSagawe.Models
{
    public class Curso
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CursoID { get; set; }

        public string Titulo { get; set; }

        public int Notas { get; set; }

        public ICollection<Matricula> Matriculas { get; set; }
    }
}
