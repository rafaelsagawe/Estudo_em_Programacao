using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BlogSagawe.Models;

/*
 1 - Posts;

1.1 - Model:
1.1.1 - IDPost; -> ok
1.1.2 - NomePost; -> ok
1.1.3 - ResumoPost; -> ok
1.1.4 - ConteudoPost; -> ok
1.1.5 - CategoriasPost;
1.1.6 - DataPost; -> Parcial (não esta voltando o valor do DB)
 */


namespace BlogSagawe.Models
{
    public class Posts
    {
        [Key] // Chave do item
        public int IdPost { get; set; }
        // ------------ Nome
        [Display(Name = "Nome do post")] // Label na pagina
        [Required(ErrorMessage = "Este item é obrigatorio")] // Item requerido/Obrigatorio
        [StringLength (20, ErrorMessage = "Deve conter no maximo 20 caracteres")] // Quantidade de Caracteres do campo
        [MinLength (4, ErrorMessage = "Nome deve ter no minimo 4 caracteres")] // Quantidade minima do campo
        public string NomePost { get; set; }

        // ------------ Resumo
        [Display(Name = "Resumo do Post")] // Label na pagina
        [Required(ErrorMessage = "Este item é obrigatorio")] // Item requerido/Obrigatorio
        [StringLength(50, ErrorMessage = "Deve conter no maximo 50 caracteres")] // Quantidade de Caracteres do campo
        public string ResumoPost { get; set; }

        // ------------ Conteudo
        [Display(Name = "Conteudo do post")] // Label na pagina
        [Required(ErrorMessage = "Este item é obrigatorio")] // Item requerido/Obrigatorio
        [StringLength(300, ErrorMessage = "Deve conter no maximo 300 caracteres")] // Quantidade de Caracteres do campo
        public string ConteudoPost { get; set; }

        // ------------ Data
        [DataType(DataType.Date)] // Tipo de dado nesse caso data, mas pode ser telefone, email ...
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)] // Formato de visualização na pagina Index, dia-mes-ano
        [Display(Name = "Data da posts")]
        public DateTime DataPost { get; set; }

    }
}
