using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace AppEstudo.Models
{
    public class ConsertoDetalhes
    {
        [Key]
        public int Id { get; set; }

        public string NomeCliente { get; set; }
        public int PecasId { get; set; }
        public decimal Total { get; set; }


        [ForeignKey("ConsertoId")]
        public virtual Conserto Conserto { get; set; }


    }
}
