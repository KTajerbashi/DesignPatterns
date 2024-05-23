﻿// <auto-generated />
using System;
using DesignPatterns.Extensions.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DesignPatterns.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20240523153141_Initial_Database")]
    partial class Initial_Database
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DesignPatterns.Composite.Examples.Categories.CategoryComponent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CategoryCompositeId")
                        .HasColumnType("int");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(21)
                        .HasColumnType("nvarchar(21)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryCompositeId");

                    b.ToTable("CategoryComponents");

                    b.HasDiscriminator<string>("Discriminator").HasValue("CategoryComponent");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("DesignPatterns.Composite.Examples.Categories.CategoryComposite", b =>
                {
                    b.HasBaseType("DesignPatterns.Composite.Examples.Categories.CategoryComponent");

                    b.HasDiscriminator().HasValue("CategoryComposite");
                });

            modelBuilder.Entity("DesignPatterns.Composite.Examples.Categories.CategoryItemLeaf", b =>
                {
                    b.HasBaseType("DesignPatterns.Composite.Examples.Categories.CategoryComponent");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("CategoryItemLeaf");
                });

            modelBuilder.Entity("DesignPatterns.Composite.Examples.Categories.CategoryComponent", b =>
                {
                    b.HasOne("DesignPatterns.Composite.Examples.Categories.CategoryComposite", null)
                        .WithMany("Categories")
                        .HasForeignKey("CategoryCompositeId");
                });

            modelBuilder.Entity("DesignPatterns.Composite.Examples.Categories.CategoryComposite", b =>
                {
                    b.Navigation("Categories");
                });
#pragma warning restore 612, 618
        }
    }
}
