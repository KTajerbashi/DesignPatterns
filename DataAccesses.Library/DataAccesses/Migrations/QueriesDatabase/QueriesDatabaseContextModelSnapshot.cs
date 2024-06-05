﻿// <auto-generated />
using System;
using DataAccesses.Contexts.QueriesContextDatabase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccesses.Migrations.QueriesDatabase
{
    [DbContext(typeof(QueriesDatabaseContext))]
    partial class QueriesDatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DataAccesses.Models.LogEvent", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ID"));

                    b.Property<string>("ControllerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("MethodControllerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MethodControllerParameters")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MethodServiceName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Request")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Response")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServiceName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Logger", "LOG");
                });
#pragma warning restore 612, 618
        }
    }
}