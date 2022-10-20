﻿// <auto-generated />
using System;
using DapperEFCoreAPI.Infra;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DapperEFCoreAPI.Migrations
{
    [DbContext(typeof(DapperEFCoreDbContext))]
    [Migration("20221020005851_InclusaoSeed")]
    partial class InclusaoSeed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DapperEFCoreAPI.Domain.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("DataAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Categoria");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DataCadastro = new DateTime(2022, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Carnes"
                        },
                        new
                        {
                            Id = 2,
                            DataCadastro = new DateTime(2022, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Produtos lácteos"
                        },
                        new
                        {
                            Id = 3,
                            DataCadastro = new DateTime(2022, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Produtos de limpeza"
                        });
                });

            modelBuilder.Entity("DapperEFCoreAPI.Domain.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DataAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("Estoque")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(8,2)");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Produto");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoriaId = 1,
                            DataCadastro = new DateTime(2022, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Descricao = "Filé Bovino Simples à vácuo",
                            Estoque = 500,
                            Nome = "Filé Simples",
                            Valor = 24.99m
                        },
                        new
                        {
                            Id = 2,
                            CategoriaId = 1,
                            DataCadastro = new DateTime(2022, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Descricao = "Filé Bovino duplo à vácuo",
                            Estoque = 350,
                            Nome = "Filé duplo",
                            Valor = 38.99m
                        },
                        new
                        {
                            Id = 3,
                            CategoriaId = 2,
                            DataCadastro = new DateTime(2022, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Descricao = "Leite integral 1L",
                            Estoque = 2000,
                            Nome = "Leite Integral",
                            Valor = 3.69m
                        },
                        new
                        {
                            Id = 4,
                            CategoriaId = 3,
                            DataCadastro = new DateTime(2022, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Descricao = "Água sanitária 5L",
                            Estoque = 1500,
                            Nome = "Água sanitária",
                            Valor = 22.69m
                        },
                        new
                        {
                            Id = 5,
                            CategoriaId = 3,
                            DataCadastro = new DateTime(2022, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Descricao = "Sabão em pó 1.6kg",
                            Estoque = 850,
                            Nome = "Sabão em pó",
                            Valor = 23.99m
                        },
                        new
                        {
                            Id = 6,
                            CategoriaId = 3,
                            DataCadastro = new DateTime(2022, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Descricao = "Limpador multiuso 5L",
                            Estoque = 500,
                            Nome = "Limpador multiuso",
                            Valor = 31.99m
                        },
                        new
                        {
                            Id = 7,
                            CategoriaId = 2,
                            DataCadastro = new DateTime(2022, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Descricao = "Margarina 500g",
                            Estoque = 1000,
                            Nome = "Margarina",
                            Valor = 5.99m
                        },
                        new
                        {
                            Id = 8,
                            CategoriaId = 2,
                            DataCadastro = new DateTime(2022, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Descricao = "Iogurte integral 170g",
                            Estoque = 1000,
                            Nome = "Iogurte integral",
                            Valor = 2.99m
                        },
                        new
                        {
                            Id = 9,
                            CategoriaId = 1,
                            DataCadastro = new DateTime(2022, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Descricao = "Carne bovina moída de contra filé resfriada",
                            Estoque = 350,
                            Nome = "Carne bovina moída de contra filé",
                            Valor = 36.29m
                        },
                        new
                        {
                            Id = 10,
                            CategoriaId = 3,
                            DataCadastro = new DateTime(2022, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Descricao = "Lava-Rouaps em Pó 1,6Kg",
                            Estoque = 1000,
                            Nome = "Lava-Roupas em Pó",
                            Valor = 21.90m
                        });
                });

            modelBuilder.Entity("DapperEFCoreAPI.Domain.Produto", b =>
                {
                    b.HasOne("DapperEFCoreAPI.Domain.Categoria", "Categoria")
                        .WithMany("Produtos")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("DapperEFCoreAPI.Domain.Categoria", b =>
                {
                    b.Navigation("Produtos");
                });
#pragma warning restore 612, 618
        }
    }
}
