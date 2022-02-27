using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        public int CursoID { get; set; } // Chave extrangeira da entidade curso

        public int EstudanteID { get; set; } // Chave extrangeira da entidade estudante

        [DisplayFormat(NullDisplayText = "Sem grade")]
        public Grade? Grade { get; set; } // Grade é um enum, com propriedade "?" null (Não conhecidade ou não atribuidade)

        // Pripriedade de Navegação
        // Referente ao curso
        public Curso Curso { get; set; }

        // Referente ao Estudadente
        public Estudante Estudante { get; set; }

    }
}
