using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppEstudo.Models
{
    public class Conserto
    {
        [Key]
        public int Id { get; set; }

        public DateTime DataEntrada { get; set; }
        public string NomeCliente { get; set; }
        public string NomeFuncionario { get; set; }
        public string NomePeca { get; set; }
        public string DescricaoDefeito { get; set; }
        public string DescricaoSolucao { get; set; }
        public decimal ValorMaoObra { get; set; }
        public decimal ValorTotalConserto { get; set; }

    }
}
