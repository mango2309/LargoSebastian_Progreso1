﻿// <auto-generated />
using System;
using LargoSebastian_Progreso1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LargoSebastian_Progreso1.Migrations
{
    [DbContext(typeof(LargoSebastian_Progreso1Context))]
    [Migration("20241029123803_PruebaProgresoI")]
    partial class PruebaProgresoI
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LargoSebastian_Progreso1.Models.Celular", b =>
                {
                    b.Property<int>("IdCelular")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCelular"));

                    b.Property<int>("Anio")
                        .HasColumnType("int");

                    b.Property<int>("LargoS")
                        .HasColumnType("int");

                    b.Property<int?>("LargoSIdNombre")
                        .HasColumnType("int");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("IdCelular");

                    b.HasIndex("LargoSIdNombre");

                    b.ToTable("Celular");
                });

            modelBuilder.Entity("LargoSebastian_Progreso1.Models.LargoS", b =>
                {
                    b.Property<int>("IdNombre")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdNombre"));

                    b.Property<decimal>("Decimal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Entero")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("Palabra")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("VerdaderoFalso")
                        .HasColumnType("bit");

                    b.HasKey("IdNombre");

                    b.ToTable("LargoS");
                });

            modelBuilder.Entity("LargoSebastian_Progreso1.Models.Celular", b =>
                {
                    b.HasOne("LargoSebastian_Progreso1.Models.LargoS", null)
                        .WithMany("Celulares")
                        .HasForeignKey("LargoSIdNombre");
                });

            modelBuilder.Entity("LargoSebastian_Progreso1.Models.LargoS", b =>
                {
                    b.Navigation("Celulares");
                });
#pragma warning restore 612, 618
        }
    }
}
