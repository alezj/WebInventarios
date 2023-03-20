﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebInventarios.Models;

#nullable disable

namespace WebInventarios.Migrations
{
    [DbContext(typeof(ConexionContext))]
    [Migration("20230320120614_add_id")]
    partial class addid
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebInventarios.Models.Almacenes", b =>
                {
                    b.Property<int>("IDAlmacen")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDAlmacen");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IDAlmacen"));

                    b.Property<string>("DescripcionAlmacen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReferenciaAlmacen")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IDAlmacen");

                    b.ToTable("Almacenes");
                });

            modelBuilder.Entity("WebInventarios.Models.Inventarios", b =>
                {
                    b.Property<int>("CantidadInv")
                        .HasColumnType("int");

                    b.Property<int>("IDAlmacen")
                        .HasColumnType("int");

                    b.Property<int>("ProductoId")
                        .HasColumnType("int")
                        .HasColumnName("ProductoID");

                    b.ToTable("Inventario", (string)null);
                });

            modelBuilder.Entity("WebInventarios.Models.Producto", b =>
                {
                    b.Property<int>("ProductoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ProductoID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductoId"));

                    b.Property<decimal?>("ProductoCan")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductoComentario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductoDesc")
                        .HasMaxLength(50)
                        .HasColumnType("nchar(50)")
                        .IsFixedLength();

                    b.HasKey("ProductoId");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("WebInventarios.Models.ViewModels.ProductosAlmacen", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IDAlmacen")
                        .HasColumnType("int");

                    b.Property<int>("ProductoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ProductosAlmacens");
                });
#pragma warning restore 612, 618
        }
    }
}
