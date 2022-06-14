﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MyTodoApp.Migrations
{
    [DbContext(typeof(MyTodoAppContext))]
    partial class MyTodoAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.5");

            modelBuilder.Entity("MyTodoApp.Models.Todo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Atualização")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Concluído")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Criação")
                        .HasColumnType("TEXT");

                    b.Property<string>("Título")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Todo");
                });
#pragma warning restore 612, 618
        }
    }
}