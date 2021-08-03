using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EscolaSagawe.Models
{
    public class Instrutor
    {
        public int ID { get; set; }

        [Required]
        [Display(Name ="Nome")]
        [StringLength(50, ErrorMessage ="O nome pode ter apenas 50 caracteres")]
        public string Nome { get; set; }

        [Required]
        [Display(Name = "Sobrenome")]
        [StringLength(250, ErrorMessage = "O sobrenome pode ter 250 caracteres")]
        public string SobreNome { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Data de admição")]
        public DateTime DataAdmicacao { get; set; }

        [Display(Name = "Nome completo")]
        public string NomeCompleto
        {
            get
            {
                return Nome + " " + SobreNome;
            }
        }

        public ICollection<Curso> Cursos { get; set; }
        public Sala sala { get; set; }

    }
}
