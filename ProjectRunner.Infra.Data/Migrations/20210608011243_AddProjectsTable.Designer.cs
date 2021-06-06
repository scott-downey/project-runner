﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectRunner.Infra.Data.Context;

namespace ProjectRunner.Infra.Data.Migrations
{
    [DbContext(typeof(SQLiteContext))]
    [Migration("20210608011243_AddProjectsTable")]
    partial class AddProjectsTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.6");

            modelBuilder.Entity("ProjectRunner.Entities.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Command")
                        .IsRequired()
                        .HasColumnType("Varchar(255)")
                        .HasColumnName("Command");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("Varchar(100)")
                        .HasColumnName("Name");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("Varchar(255)")
                        .HasColumnName("Path");

                    b.HasKey("Id");

                    b.ToTable("Projects");
                });
#pragma warning restore 612, 618
        }
    }
}
