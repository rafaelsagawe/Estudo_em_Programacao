using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EscolaSagawe.Models
{
    public class Curso
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Codigo")]
        public int CursoID { get; set; }

        [StringLength(50, MinimumLength = 3, ErrorMessage ="No minimo 3 e no maximo 50 caracteres")]
        public string Titulo { get; set; }

        [Range(0, 10)]
        public int Notas { get; set; }

        public int DepartamentoID { get; set; }

        public Departamento Departamento { get; set; }

        // Propriedade Navegação
        public ICollection<Matricula> Matriculas { get; set; }


        public ICollection<Instrutor> Instrutors { get; set; }

    }
}
