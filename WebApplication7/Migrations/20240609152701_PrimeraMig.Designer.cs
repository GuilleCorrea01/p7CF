﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication7.Models;

#nullable disable

namespace WebApplication7.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20240609152701_PrimeraMig")]
    partial class PrimeraMig
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebApplication7.Models.Libros", b =>
                {
                    b.Property<int>("Lib_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Lib_Id"));

                    b.Property<string>("Lib_Autor")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Lib_Genero")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Lib_Nombre")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Lib_Status")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Lib_TipoProyecto")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Lib_Id");

                    b.ToTable("Libros");
                });

            modelBuilder.Entity("WebApplication7.Models.Personajes", b =>
                {
                    b.Property<int>("Per_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Per_Id"));

                    b.Property<int>("LibrosLib_Id")
                        .HasColumnType("int");

                    b.Property<string>("Per_Apellido")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Per_Descripcion")
                        .IsRequired()
                        .HasMaxLength(101)
                        .HasColumnType("nvarchar(101)");

                    b.Property<DateTime>("Per_FechaNacimiento")
                        .HasMaxLength(255)
                        .HasColumnType("datetime2");

                    b.Property<int>("Per_LibId")
                        .HasColumnType("int");

                    b.Property<string>("Per_LugarNacimiento")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Per_Nombre")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("Per_RolId")
                        .HasColumnType("int");

                    b.Property<string>("Per_Status")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Per_Id");

                    b.HasIndex("LibrosLib_Id");

                    b.HasIndex("Per_RolId");

                    b.ToTable("Personajes");
                });

            modelBuilder.Entity("WebApplication7.Models.Roles", b =>
                {
                    b.Property<int>("Rol_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Rol_Id"));

                    b.Property<string>("Rol_Descripcion")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Rol_Status")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Rol_Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("WebApplication7.Models.Personajes", b =>
                {
                    b.HasOne("WebApplication7.Models.Libros", "Libros")
                        .WithMany("Personajes")
                        .HasForeignKey("LibrosLib_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication7.Models.Roles", "Per_Rol")
                        .WithMany("Personajes")
                        .HasForeignKey("Per_RolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Libros");

                    b.Navigation("Per_Rol");
                });

            modelBuilder.Entity("WebApplication7.Models.Libros", b =>
                {
                    b.Navigation("Personajes");
                });

            modelBuilder.Entity("WebApplication7.Models.Roles", b =>
                {
                    b.Navigation("Personajes");
                });
#pragma warning restore 612, 618
        }
    }
}
