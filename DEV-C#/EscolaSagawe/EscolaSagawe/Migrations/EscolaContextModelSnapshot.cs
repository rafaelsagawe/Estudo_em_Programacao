﻿// <auto-generated />
using System;
using EscolaSagawe.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EscolaSagawe.Migrations
{
    [DbContext(typeof(EscolaContext))]
    partial class EscolaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CursoInstrutor", b =>
                {
                    b.Property<int>("CursosCursoID")
                        .HasColumnType("int");

                    b.Property<int>("InstrutorsID")
                        .HasColumnType("int");

                    b.HasKey("CursosCursoID", "InstrutorsID");

                    b.HasIndex("InstrutorsID");

                    b.ToTable("CursoInstrutor");
                });

            modelBuilder.Entity("EscolaSagawe.Models.Curso", b =>
                {
                    b.Property<int>("CursoID")
                        .HasColumnType("int");

                    b.Property<int>("DepartamentoID")
                        .HasColumnType("int");

                    b.Property<int>("Notas")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CursoID");

                    b.HasIndex("DepartamentoID");

                    b.ToTable("Cursos");
                });

            modelBuilder.Entity("EscolaSagawe.Models.CursoAdministrado", b =>
                {
                    b.Property<int>("CursoID")
                        .HasColumnType("int");

                    b.Property<int>("InstrutorID")
                        .HasColumnType("int");

                    b.HasKey("CursoID", "InstrutorID");

                    b.HasIndex("InstrutorID");

                    b.ToTable("cursoAdministrados");
                });

            modelBuilder.Entity("EscolaSagawe.Models.Departamento", b =>
                {
                    b.Property<int>("DepartamentoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataInicial")
                        .HasColumnType("datetime2");

                    b.Property<int?>("InstrutorID")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Valor")
                        .HasColumnType("money");

                    b.HasKey("DepartamentoID");

                    b.HasIndex("InstrutorID");

                    b.ToTable("Departamentos");
                });

            modelBuilder.Entity("EscolaSagawe.Models.Estudante", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataMatricula")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("ID");

                    b.ToTable("Estudantes");
                });

            modelBuilder.Entity("EscolaSagawe.Models.Instrutor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataAdmicacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SobreNome")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("ID");

                    b.ToTable("Instrutors");
                });

            modelBuilder.Entity("EscolaSagawe.Models.Matricula", b =>
                {
                    b.Property<int>("MatriculaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CursoID")
                        .HasColumnType("int");

                    b.Property<int>("EstudanteID")
                        .HasColumnType("int");

                    b.Property<int?>("Grade")
                        .HasColumnType("int");

                    b.HasKey("MatriculaID");

                    b.HasIndex("CursoID");

                    b.HasIndex("EstudanteID");

                    b.ToTable("Matriculas");
                });

            modelBuilder.Entity("EscolaSagawe.Models.Sala", b =>
                {
                    b.Property<int>("InstrutorID")
                        .HasColumnType("int");

                    b.Property<string>("Localizacao")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("InstrutorID");

                    b.ToTable("Salas");
                });

            modelBuilder.Entity("CursoInstrutor", b =>
                {
                    b.HasOne("EscolaSagawe.Models.Curso", null)
                        .WithMany()
                        .HasForeignKey("CursosCursoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EscolaSagawe.Models.Instrutor", null)
                        .WithMany()
                        .HasForeignKey("InstrutorsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EscolaSagawe.Models.Curso", b =>
                {
                    b.HasOne("EscolaSagawe.Models.Departamento", "Departamento")
                        .WithMany("Cursos")
                        .HasForeignKey("DepartamentoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departamento");
                });

            modelBuilder.Entity("EscolaSagawe.Models.CursoAdministrado", b =>
                {
                    b.HasOne("EscolaSagawe.Models.Curso", "Curso")
                        .WithMany()
                        .HasForeignKey("CursoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EscolaSagawe.Models.Instrutor", "Instrutor")
                        .WithMany()
                        .HasForeignKey("InstrutorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Curso");

                    b.Navigation("Instrutor");
                });

            modelBuilder.Entity("EscolaSagawe.Models.Departamento", b =>
                {
                    b.HasOne("EscolaSagawe.Models.Instrutor", "Administrador")
                        .WithMany()
                        .HasForeignKey("InstrutorID");

                    b.Navigation("Administrador");
                });

            modelBuilder.Entity("EscolaSagawe.Models.Matricula", b =>
                {
                    b.HasOne("EscolaSagawe.Models.Curso", "Curso")
                        .WithMany("Matriculas")
                        .HasForeignKey("CursoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EscolaSagawe.Models.Estudante", "Estudante")
                        .WithMany("Matriculas")
                        .HasForeignKey("EstudanteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Curso");

                    b.Navigation("Estudante");
                });

            modelBuilder.Entity("EscolaSagawe.Models.Sala", b =>
                {
                    b.HasOne("EscolaSagawe.Models.Instrutor", "Instrutor")
                        .WithOne("sala")
                        .HasForeignKey("EscolaSagawe.Models.Sala", "InstrutorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Instrutor");
                });

            modelBuilder.Entity("EscolaSagawe.Models.Curso", b =>
                {
                    b.Navigation("Matriculas");
                });

            modelBuilder.Entity("EscolaSagawe.Models.Departamento", b =>
                {
                    b.Navigation("Cursos");
                });

            modelBuilder.Entity("EscolaSagawe.Models.Estudante", b =>
                {
                    b.Navigation("Matriculas");
                });

            modelBuilder.Entity("EscolaSagawe.Models.Instrutor", b =>
                {
                    b.Navigation("sala");
                });
#pragma warning restore 612, 618
        }
    }
}
