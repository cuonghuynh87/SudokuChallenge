﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SudokuSolver.WebApi.Data;

#nullable disable

namespace SudokuSolver.WebApi.Migrations
{
    [DbContext(typeof(SudokuDbContext))]
    partial class SudokuDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SudokuSolver.WebApi.Models.Solver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Result")
                        .IsRequired()
                        .HasMaxLength(81)
                        .HasColumnType("nvarchar(81)");

                    b.HasKey("Id");

                    b.ToTable("Solvers");
                });
#pragma warning restore 612, 618
        }
    }
}