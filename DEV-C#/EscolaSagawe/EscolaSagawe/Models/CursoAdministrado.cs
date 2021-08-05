using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EscolaSagawe.Models
{
    public class CursoAdministrado
    {
        public int InstrutorID { get; set; }
        public int CursoID { get; set; }
        public Instrutor Instrutor { get; set; }
        public Curso Curso { get; set; }
    }
}
