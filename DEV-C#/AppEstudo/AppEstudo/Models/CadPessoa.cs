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
                return Convert.ToInt32(IdadeCalculada.ToString().Substring(0, 2));
            }
        }
        
        public TimeSpan IdadeCalculada
        {
            get
            {
                return IdadeCalculadaBruta /12 /30;
            }
        }

        public TimeSpan IdadeCalculadaBruta
        {
            get
            {
                return (DateTime.Now.Date - DataNascimento) ;
            }
        }
    }
}
