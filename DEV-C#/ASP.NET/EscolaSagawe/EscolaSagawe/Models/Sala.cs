using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EscolaSagawe.Models
{
    public class Sala
    {
        [Key]
        public int InstrutorID { get; set; }

        [StringLength(50)]
        [Display(Name ="Local da Sala")]
        public string Localizacao { get; set; }

        public Instrutor Instrutor { get; set; }
    }
}
