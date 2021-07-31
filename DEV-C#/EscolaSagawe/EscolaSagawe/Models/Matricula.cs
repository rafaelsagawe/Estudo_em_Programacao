using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscolaSagawe.Models
{

    // Grade 
    public enum Grade
    {
        A, B, C, D, E
    }

    public class Matricula
    {
        public int MatriculaID { get; set; }

        public int CursoID { get; set; }

        public int EstudanteID { get; set; }

        public Grade? Grade { get; set; }

        public Curso Curso { get; set; }

        public Estudante Estudante { get; set; }

    }
}
