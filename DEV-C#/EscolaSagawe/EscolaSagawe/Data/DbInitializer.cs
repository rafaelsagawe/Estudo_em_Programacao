using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using EscolaSagawe.Models;

namespace EscolaSagawe.Data
{
    public static class DbInitializer
    {
        public static void Initialize(EscolaContext context)
        {
            //context.Database.EnsureCreated();

            // Look for any students.
            if (context.Estudantes.Any())
            {
                return;   // DB has been seeded
            }

            var Estudante = new Estudante[]
            {
                new Estudante { Nome = "Carson",   Sobrenome = "Alexander",
                    DataMatricula = DateTime.Parse("2010-09-01") },
                new Estudante { Nome = "Meredith", Sobrenome = "Alonso",
                    DataMatricula = DateTime.Parse("2012-09-01") },
                new Estudante { Nome = "Arturo",   Sobrenome = "Anand",
                    DataMatricula = DateTime.Parse("2013-09-01") },
                new Estudante { Nome = "Gytis",    Sobrenome = "Barzdukas",
                    DataMatricula = DateTime.Parse("2012-09-01") },
                new Estudante { Nome = "Yan",      Sobrenome = "Li",
                    DataMatricula = DateTime.Parse("2012-09-01") },
                new Estudante { Nome = "Peggy",    Sobrenome = "Justice",
                    DataMatricula = DateTime.Parse("2011-09-01") },
                new Estudante { Nome = "Laura",    Sobrenome = "Norman",
                    DataMatricula = DateTime.Parse("2013-09-01") },
                new Estudante { Nome = "Nino",     Sobrenome = "Olivetto",
                    DataMatricula = DateTime.Parse("2005-09-01") }
            };

            foreach (Estudante s in Estudante)
            {
                context.Estudantes.Add(s);
            }
            context.SaveChanges();

            var Instrutores = new Instrutor[]
            {
                new Instrutor { Nome = "Kim",     SobreNome = "Abercrombie",
                    DataAdmicacao = DateTime.Parse("11-03-1995") },
                new Instrutor { Nome = "Fadi",    SobreNome = "Fakhouri",
                    DataAdmicacao = DateTime.Parse("2002-07-06") },
                new Instrutor { Nome = "Roger",   SobreNome = "Harui",
                    DataAdmicacao = DateTime.Parse("1998-07-01") },
                new Instrutor { Nome = "Candace", SobreNome = "Kapoor",
                    DataAdmicacao = DateTime.Parse("2001-01-15") },
                new Instrutor { Nome = "Roger",   SobreNome = "Zheng",
                    DataAdmicacao = DateTime.Parse("2004-02-12") }
            };

            foreach (Instrutor i in Instrutores)
            {
                context.Instrutors.Add(i);
            }
            context.SaveChanges();

            var departments = new Departamento[]
            {
                new Departamento { Nome = "English",     Valor = 350000,
                    DataInicial = DateTime.Parse("2007-09-01"),
                    InstrutorID  = Instrutores.Single( i => i.SobreNome == "Abercrombie").ID },
                new Departamento { Nome = "Mathematics", Valor = 100000,
                    DataInicial = DateTime.Parse("2007-09-01"),
                    InstrutorID  = Instrutores.Single( i => i.SobreNome == "Fakhouri").ID },
                new Departamento { Nome = "Engineering", Valor = 350000,
                    DataInicial = DateTime.Parse("2007-09-01"),
                    InstrutorID  = Instrutores.Single( i => i.SobreNome == "Harui").ID },
                new Departamento { Nome = "Economics",   Valor = 100000,
                    DataInicial = DateTime.Parse("2007-09-01"),
                    InstrutorID  = Instrutores.Single( i => i.SobreNome == "Kapoor").ID }
            };

            foreach (Departamento d in departments)
            {
                context.Departamentos.Add(d);
            }
            context.SaveChanges();

            var courses = new Curso[]
            {
                new Curso {CursoID = 1050, Titulo = "Chemistry",      Notas = 3,
                    DepartamentoID = departments.Single( s => s.Nome == "Engineering").DepartamentoID
                },
                new Curso {CursoID = 4022, Titulo = "Microeconomics", Notas = 3,
                    DepartamentoID = departments.Single( s => s.Nome == "Economics").DepartamentoID
                },
                new Curso {CursoID = 4041, Titulo = "Macroeconomics", Notas = 3,
                    DepartamentoID = departments.Single( s => s.Nome == "Economics").DepartamentoID
                },
                new Curso {CursoID = 1045, Titulo = "Calculus",       Notas = 4,
                    DepartamentoID = departments.Single( s => s.Nome == "Mathematics").DepartamentoID
                },
                new Curso {CursoID = 3141, Titulo = "Trigonometry",   Notas = 4,
                    DepartamentoID = departments.Single( s => s.Nome == "Mathematics").DepartamentoID
                },
                new Curso {CursoID = 2021, Titulo = "Composition",    Notas = 3,
                    DepartamentoID = departments.Single( s => s.Nome == "English").DepartamentoID
                },
                new Curso {CursoID = 2042, Titulo = "Literature",     Notas = 4,
                    DepartamentoID = departments.Single( s => s.Nome == "English").DepartamentoID
                },
            };

            foreach (Curso c in courses)
            {
                context.Cursos.Add(c);
            }
            context.SaveChanges();

            var officeAssignments = new Sala[]
            {
                new Sala {
                    InstrutorID = Instrutores.Single( i => i.SobreNome == "Fakhouri").ID,
                    Localizacao = "Smith 17" },
                new Sala {
                    InstrutorID = Instrutores.Single( i => i.SobreNome == "Harui").ID,
                    Localizacao = "Gowan 27" },
                new Sala {
                    InstrutorID = Instrutores.Single( i => i.SobreNome == "Kapoor").ID,
                    Localizacao = "Thompson 304" },
            };

            foreach (Sala o in officeAssignments)
            {
                context.Salas.Add(o);
            }
            context.SaveChanges();

            // Trexo do cursoadministrado
            var courseInstructors = new CursoAdministrado[]
            {
                new CursoAdministrado {
                    CursoID = courses.Single(c => c.Titulo == "Chemistry" ).CursoID,
                    InstrutorID = Instrutores.Single(i => i.SobreNome == "Kapoor").ID
                    },
                new CursoAdministrado {
                    CursoID = courses.Single(c => c.Titulo == "Chemistry" ).CursoID,
                    InstrutorID = Instrutores.Single(i => i.SobreNome == "Harui").ID
                    },
                new CursoAdministrado {
                    CursoID = courses.Single(c => c.Titulo == "Microeconomics" ).CursoID,
                    InstrutorID = Instrutores.Single(i => i.SobreNome == "Zheng").ID
                    },
                new CursoAdministrado {
                    CursoID = courses.Single(c => c.Titulo == "Macroeconomics" ).CursoID,
                    InstrutorID = Instrutores.Single(i => i.SobreNome == "Zheng").ID
                    },
                new CursoAdministrado {
                    CursoID = courses.Single(c => c.Titulo == "Calculus" ).CursoID,
                    InstrutorID = Instrutores.Single(i => i.SobreNome == "Fakhouri").ID
                    },
                new CursoAdministrado {
                    CursoID = courses.Single(c => c.Titulo == "Trigonometry" ).CursoID,
                    InstrutorID = Instrutores.Single(i => i.SobreNome == "Harui").ID
                    },
                new CursoAdministrado {
                    CursoID = courses.Single(c => c.Titulo == "Composition" ).CursoID,
                    InstrutorID = Instrutores.Single(i => i.SobreNome == "Abercrombie").ID
                    },
                new CursoAdministrado {
                    CursoID = courses.Single(c => c.Titulo == "Literature" ).CursoID,
                    InstrutorID = Instrutores.Single(i => i.SobreNome == "Abercrombie").ID
                    },
            };

            foreach (CursoAdministrado ci in courseInstructors)
            {
                context.cursoAdministrados.Add(ci);
            }
            context.SaveChanges();

            // Trexo do cursoadministrado



            var enrollments = new Matricula[]
            {
                new Matricula {
                    EstudanteID = Estudante.Single(s => s.Sobrenome == "Alexander").ID,
                    CursoID = courses.Single(c => c.Titulo == "Chemistry" ).CursoID,
                    Grade = Grade.A
                },
                    new Matricula {
                    EstudanteID = Estudante.Single(s => s.Sobrenome == "Alexander").ID,
                    CursoID = courses.Single(c => c.Titulo == "Microeconomics" ).CursoID,
                    Grade = Grade.C
                    },
                    new Matricula {
                    EstudanteID = Estudante.Single(s => s.Sobrenome == "Alexander").ID,
                    CursoID = courses.Single(c => c.Titulo == "Macroeconomics" ).CursoID,
                    Grade = Grade.B
                    },
                    new Matricula {
                        EstudanteID = Estudante.Single(s => s.Sobrenome == "Alonso").ID,
                    CursoID = courses.Single(c => c.Titulo == "Calculus" ).CursoID,
                    Grade = Grade.B
                    },
                    new Matricula {
                        EstudanteID = Estudante.Single(s => s.Sobrenome == "Alonso").ID,
                    CursoID = courses.Single(c => c.Titulo == "Trigonometry" ).CursoID,
                    Grade = Grade.B
                    },
                    new Matricula {
                    EstudanteID = Estudante.Single(s => s.Sobrenome == "Alonso").ID,
                    CursoID = courses.Single(c => c.Titulo == "Composition" ).CursoID,
                    Grade = Grade.B
                    },
                    new Matricula {
                    EstudanteID = Estudante.Single(s => s.Sobrenome == "Anand").ID,
                    CursoID = courses.Single(c => c.Titulo == "Chemistry" ).CursoID
                    },
                    new Matricula {
                    EstudanteID = Estudante.Single(s => s.Sobrenome == "Anand").ID,
                    CursoID = courses.Single(c => c.Titulo == "Microeconomics").CursoID,
                    Grade = Grade.B
                    },
                new Matricula {
                    EstudanteID = Estudante.Single(s => s.Sobrenome == "Barzdukas").ID,
                    CursoID = courses.Single(c => c.Titulo == "Chemistry").CursoID,
                    Grade = Grade.B
                    },
                    new Matricula {
                    EstudanteID = Estudante.Single(s => s.Sobrenome == "Li").ID,
                    CursoID = courses.Single(c => c.Titulo == "Composition").CursoID,
                    Grade = Grade.B
                    },
                    new Matricula {
                    EstudanteID = Estudante.Single(s => s.Sobrenome == "Justice").ID,
                    CursoID = courses.Single(c => c.Titulo == "Literature").CursoID,
                    Grade = Grade.B
                    }
            };

            foreach (Matricula e in enrollments)
            {
                var enrollmentInDataBase = context.Matriculas.Where(
                    s =>
                            s.Estudante.ID == e.EstudanteID &&
                            s.Curso.CursoID == e.CursoID).SingleOrDefault();
                if (enrollmentInDataBase == null)
                {
                    context.Matriculas.Add(e);
                }
            }
            context.SaveChanges();
        }
    }
}