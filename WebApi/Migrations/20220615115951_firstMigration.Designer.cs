﻿// <auto-generated />
using System;
using DataAccess.Concrete.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace WebApi.Migrations
{
    [DbContext(typeof(KusysContext))]
    [Migration("20220615115951_firstMigration")]
    partial class firstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.HasSequence<int>("course_hilo")
                .StartsAt(100L);

            modelBuilder.HasSequence<int>("courseMatch_hilo")
                .StartsAt(100L);

            modelBuilder.HasSequence<int>("student_hilo")
                .StartsAt(100L);

            modelBuilder.Entity("Entities.Concrete.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseHiLo("course_hilo");

                    b.Property<string>("CourseName")
                        .HasColumnType("varchar(50)");

                    b.HasKey("CourseId");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("Entities.Concrete.CourseMatch", b =>
                {
                    b.Property<int>("CourseMatchId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseHiLo("courseMatch_hilo");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("CourseMatchId");

                    b.ToTable("CourseMatch");
                });

            modelBuilder.Entity("Entities.Concrete.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseHiLo("student_hilo");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2(7)");

                    b.Property<string>("FirstName")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("LastName")
                        .HasColumnType("varchar(50)");

                    b.HasKey("StudentId");

                    b.ToTable("Student");
                });
#pragma warning restore 612, 618
        }
    }
}
