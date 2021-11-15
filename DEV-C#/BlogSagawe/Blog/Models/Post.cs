using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class Post
    {
        [Key]
        public int idPost {get;set;}

        [Display(Name ="Nome da postagem")]
        public string NomePost { get; set; }

        public string ResumoPost { get; set; }
        public string ConteudoPost { get; set; }
        public string CategoriasPost { get; set; }
        public DateTime DataPost { get; set; } = DateTime.Now;
        public string UsuarioCriador { get; set; }
    }
}
