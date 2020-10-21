﻿// <auto-generated />
using System;
using BlazorApp1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlazorApp1.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20201021013712_inicial")]
    partial class inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9");

            modelBuilder.Entity("BlazorApp1.Data.Tasks", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Estimate")
                        .HasColumnName("Estimate")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("Expiration")
                        .HasColumnName("Expiration")
                        .HasColumnType("datetime");

                    b.Property<string>("State")
                        .HasColumnName("State")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Title")
                        .HasColumnName("Name")
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Task");
                });
#pragma warning restore 612, 618
        }
    }
}
