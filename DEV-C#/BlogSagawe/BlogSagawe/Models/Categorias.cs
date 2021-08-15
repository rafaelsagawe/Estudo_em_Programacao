using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace BlogSagawe.Models
{
    public class Categorias
    {
       [Key]
        public int IdCategoria { get; set; }

        [Display (Name = "Nome da categoria")]
        [StringLength(20, ErrorMessage = "A categoria deve ter no maximo 20 caracteres")]
        public string NomeCategoria { get; set; }

        [Display (Name = "Descrição da categoria")]
        [StringLength (250, ErrorMessage = "A descrição não deve ser maior à 250 caracters.")]
        public string DescricaaCategoria { get; set; }

        public virtual ICollection<Posts> Posts { get; set; }
    }
}
