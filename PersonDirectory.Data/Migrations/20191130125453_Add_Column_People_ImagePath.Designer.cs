﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PersonDirectory.Data.Models;

namespace PersonDirectory.Data.Migrations
{
    [DbContext(typeof(PersonDirectoryContext))]
    [Migration("20191130125453_Add_Column_People_ImagePath")]
    partial class Add_Column_People_ImagePath
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PersonDirectory.Data.Models.City", b =>
                {
                    b.Property<short>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("PersonDirectory.Data.Models.Gender", b =>
                {
                    b.Property<byte>("Id")
                        .HasColumnType("tinyint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genders");
                });

            modelBuilder.Entity("PersonDirectory.Data.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("datetime2");

                    b.Property<short>("CityId")
                        .HasColumnType("smallint");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<byte>("GenderId")
                        .HasColumnType("tinyint");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("PersonalNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(11)")
                        .HasMaxLength(11);

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("GenderId");

                    b.ToTable("People");
                });

            modelBuilder.Entity("PersonDirectory.Data.Models.PhoneNumber", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int?>("PersonId")
                        .HasColumnType("int");

                    b.Property<byte>("Type")
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("PhoneNumbers");
                });

            modelBuilder.Entity("PersonDirectory.Data.Models.RelatedPerson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<byte>("RelationType")
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("RelatedPeople");
                });

            modelBuilder.Entity("PersonDirectory.Data.Models.RelationType", b =>
                {
                    b.Property<byte>("Id")
                        .HasColumnType("tinyint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RelationTypes");
                });

            modelBuilder.Entity("PersonDirectory.Data.Models.Person", b =>
                {
                    b.HasOne("PersonDirectory.Data.Models.City", "City")
                        .WithMany("Persons")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PersonDirectory.Data.Models.Gender", "Gender")
                        .WithMany("Persons")
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PersonDirectory.Data.Models.PhoneNumber", b =>
                {
                    b.HasOne("PersonDirectory.Data.Models.Person", "Person")
                        .WithMany("PhoneNumbers")
                        .HasForeignKey("PersonId");
                });

            modelBuilder.Entity("PersonDirectory.Data.Models.RelatedPerson", b =>
                {
                    b.HasOne("PersonDirectory.Data.Models.Person", "Person")
                        .WithMany("RelatedPeople")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
