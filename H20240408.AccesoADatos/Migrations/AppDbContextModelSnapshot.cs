﻿// <auto-generated />
using System;
using H20240408.AccesoADatos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace H20240408.AccesoADatos.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PersonaH", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ApellidoH")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ComentarioH")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("EstatusH")
                        .HasColumnType("tinyint");

                    b.Property<DateTime>("FechaNacimientoH")
                        .HasColumnType("datetime2");

                    b.Property<string>("NombreH")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("SueldoH")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("PersonasH");
                });
#pragma warning restore 612, 618
        }
    }
}