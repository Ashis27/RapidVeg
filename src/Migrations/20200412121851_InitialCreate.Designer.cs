﻿// <auto-generated />
using System;
using DotNetCoreSqlDb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DotNetCoreSqlDb.Migrations
{
    [DbContext(typeof(MyDatabaseContext))]
    [Migration("20200412121851_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("DotNetCoreSqlDb.Models.Todo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Description");

                    b.Property<bool>("IsActive");

                    b.HasKey("ID");

                    b.ToTable("Todo");
                });

            modelBuilder.Entity("MvcMovie.Models.Movie", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<decimal>("Price");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasMaxLength(5);

                    b.Property<DateTime>("ReleaseDate");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.HasKey("ID");

                    b.ToTable("Movie");
                });
#pragma warning restore 612, 618
        }
    }
}
