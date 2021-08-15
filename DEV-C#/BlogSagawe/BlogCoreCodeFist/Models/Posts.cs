using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogCoreCodeFist.Models
{

    public partial class Posts
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Nome do post")]
        [StringLength(20, ErrorMessage ="Nome do post deve ter 20 caracteres")]
        [Required(ErrorMessage = "Preciso do nome do post")]
        public string NomePost { get; set; }

        [Display(Name ="Resumo dos post")]
        [StringLength(50, ErrorMessage = "Nome do post deve ter 50 caracteres")]
        [Required(ErrorMessage = "Preciso do resumo do post")]
        public string ResumoPost { get; set; }
        
        [Display (Name = "Conteudo")]
        [Required(ErrorMessage ="É obrigatorio o criar o conteudo do post")]
        public string ConteudoPost { get; set; }


        [Display (Name = "Lista de Categorias")]
        public int IDCategorias { get; set; }

        [ForeignKey("IDCategorias")]
        public virtual Categorias Categorias { get; set; }

    }
}
