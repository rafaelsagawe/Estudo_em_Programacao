using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EscolaSagawe.Models
{
    public class Estudante
    {
        public int ID { get; set; }

        [StringLength(250)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [Required]
        public string Nome { get; set; }

        [Required]
        [StringLength(250)]
        public string Sobrenome { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0: dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Data da Matricula")]
        public DateTime DataMatricula { get; set; }

        [Display(Name = "Nome completo")]
        public string NomeCompleto
        {
            get
            {
                return Nome + " " + Sobrenome;
            }
        }


        public ICollection<Matricula> Matriculas { get; set; }
    }
}
