using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MeuToDoApp.Models
{
    public class Notas
    {
        [Key]
        public int idNota { get; set; }

        public string ToDoTitulo { get; set; } 

        public string descricao { get; set; }

        public DateTime dataCriacao { get; set; } = DateTime.Now;



    }
}
