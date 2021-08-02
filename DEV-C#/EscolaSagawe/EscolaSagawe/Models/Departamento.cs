using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EscolaSagawe.Models
{
    public class Departamento
    {
        public int DepartamentoID { get; set; }

        [StringLength(50), MinLength(3)]
        public string Nome { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public decimal Valor { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Data de inicio")]
        public DateTime DataInicial { get; set; }

        public int? InstrutorID { get; set; }

        public Instrutor Administrador { get; set; }
        
        public ICollection<Curso> Cursos { get; set; }
    }
}
