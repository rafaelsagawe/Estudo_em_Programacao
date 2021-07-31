using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EscolaSagawe.Models;

//Inicializar o BD com os dados de teste

namespace EscolaSagawe.Data
{
    public static class DbInitializer
    {
        public static void Initialize(EscolaContext context)
        {
            context.Database.EnsureCreated();

            // Look for any Estudantess.
            if (context.Estudantes.Any())
            {
                return;   // DB has been seeded
            }

            var Estudantes = new Estudante[]
            {
            new Estudante{Nome="Carson",Sobrenome="Alexander",DataMatricula=DateTime.Parse("2005-09-01")},
            new Estudante{Nome="Meredith",Sobrenome="Alonso",DataMatricula=DateTime.Parse("2002-09-01")},
            new Estudante{Nome="Arturo",Sobrenome="Anand",DataMatricula=DateTime.Parse("2003-09-01")},
            new Estudante{Nome="Gytis",Sobrenome="Barzdukas",DataMatricula=DateTime.Parse("2002-09-01")},
            new Estudante{Nome="Yan",Sobrenome="Li",DataMatricula=DateTime.Parse("2002-09-01")},
            new Estudante{Nome="Peggy",Sobrenome="Justice",DataMatricula=DateTime.Parse("2001-09-01")},
            new Estudante{Nome="Laura",Sobrenome="Norman",DataMatricula=DateTime.Parse("2003-09-01")},
            new Estudante{Nome="Nino",Sobrenome="Olivetto",DataMatricula=DateTime.Parse("2005-09-01")}
            };
            foreach (Estudante s in Estudantes)
            {
                context.Estudantes.Add(s);
            }
            context.SaveChanges();

            var Cursos = new Curso[]
            {
            new Curso{CursoID=1050,Titulo="Chemistry",Notas=3},
            new Curso{CursoID=4022,Titulo="Microeconomics",Notas=3},
            new Curso{CursoID=4041,Titulo="Macroeconomics",Notas=3},
            new Curso{CursoID=1045,Titulo="Calculus",Notas=4},
            new Curso{CursoID=3141,Titulo="Trigonometry",Notas=4},
            new Curso{CursoID=2021,Titulo="Composition",Notas=3},
            new Curso{CursoID=2042,Titulo="Literature",Notas=4}
            };
            foreach (Curso c in Cursos)
            {
                context.Cursos.Add(c);
            }
            context.SaveChanges();

            var Matricula = new []
            {
            new Matricula{EstudanteID=1,CursoID=1050,Grade=Grade.A},
            new Matricula{EstudanteID=1,CursoID=4022,Grade=Grade.C},
            new Matricula{EstudanteID=1,CursoID=4041,Grade=Grade.B},
            new Matricula{EstudanteID=2,CursoID=1045,Grade=Grade.B},
            new Matricula{EstudanteID=2,CursoID=3141,Grade=Grade.E},
            new Matricula{EstudanteID=2,CursoID=2021,Grade=Grade.E},
            new Matricula{EstudanteID=3,CursoID=1050},
            new Matricula{EstudanteID=4,CursoID=1050},
            new Matricula{EstudanteID=4,CursoID=4022,Grade=Grade.E},
            new Matricula{EstudanteID=5,CursoID=4041,Grade=Grade.C},
            new Matricula{EstudanteID=6,CursoID=1045},
            new Matricula{EstudanteID=7,CursoID=3141,Grade=Grade.A},
            };
            foreach (Matricula e in Matricula)
            {
                context.Matriculas.Add(e);
            }
            context.SaveChanges();
        }
    }
}
