using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AppEstudo.Models
{
    public class CadPessoa
    {
        [Key]
        public int IdPessoa { get; set; }
      

        public string NomePrimeiro { get; set; }

        public string SubreNome { get; set; }

        [DisplayFormat(DataFormatString = "{0 : dd MMM yyyy}")]
        [Display(Name ="Data de Nascimento")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento {get; set;}
    

    public string NomeCompleto
        { 
            get
            {   
                // Contatena o primeiro nome com o sobrenome e 
                return string.Concat(NomePrimeiro + " " + SubreNome);
            }
        }


    public int Idade
        /*
         o Tipo DateTime não realiza calculos para proporcionar o calculo de idade o é necesario usar o tipo TimeSpan
         */
        {
            get
            {
                return DateTime.Now.Year - AnoNascimento;
            }
        }
        
        public int AnoNascimento
        {
            get
            {
                return Convert.ToInt32(DataNascimento.Year.ToString());

            }
        }
    }
}
