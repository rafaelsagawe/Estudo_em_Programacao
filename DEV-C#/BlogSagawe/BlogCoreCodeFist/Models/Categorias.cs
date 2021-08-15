using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BlogCoreCodeFist.Models
{
    public class Categorias
    {
        [Key]
        public int IDCategorias { get; set; }

        [Required(ErrorMessage ="Preciso do Nome da categoria")]
        public string NomeCategoria { get; set; }

        public string DescricaoCategoria { get; set; }

    }
}
