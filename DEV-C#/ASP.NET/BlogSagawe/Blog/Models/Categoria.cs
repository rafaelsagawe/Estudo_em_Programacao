using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class Categoria
    {
        [Key]
        public int idCategoria { get; set; }

        [Display(Name ="Categoria")]
        public string CategoriaNome { get; set; }

        [Display(Name = "Descrição")]
        public string CategoriaDescricao { get; set; }

    }
}
