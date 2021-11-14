using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MeuToDoApp.Models
{
    public class Todo
    {
        public int Id {get; set;}

        [DisplayName("Título")]
        [Required(ErrorMessage ="Campo obrigatório")]
        public string Titulo {get; set;}

        public bool Feito {get; set;}
        
        [DisplayName("Data de criação")]
        public DateTime DataCriacao {get; set;} = DateTime.Now;

        [DisplayName("Data de Alteração")]
        public DateTime DataAtualizacao {get; set;} = DateTime.Now;

        public string Usuario {get; set;}
    }
}