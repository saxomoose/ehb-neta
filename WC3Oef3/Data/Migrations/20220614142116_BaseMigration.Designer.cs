﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WC3Oef3.Data;

namespace WC3Oef3.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220614142116_BaseMigration")]
    partial class BaseMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WC3Oef3.Models.Punt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("VakId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.HasIndex("VakId");

                    b.ToTable("Punten");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Score = 20,
                            StudentId = 8,
                            VakId = 1
                        });
                });

            modelBuilder.Entity("WC3Oef3.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naam")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Studenten");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Naam = "Paul"
                        },
                        new
                        {
                            Id = 2,
                            Naam = "Marvin"
                        },
                        new
                        {
                            Id = 3,
                            Naam = "Michael"
                        },
                        new
                        {
                            Id = 4,
                            Naam = "Amber"
                        },
                        new
                        {
                            Id = 5,
                            Naam = "Anna"
                        },
                        new
                        {
                            Id = 6,
                            Naam = "Belle"
                        },
                        new
                        {
                            Id = 7,
                            Naam = "Carrie"
                        },
                        new
                        {
                            Id = 8,
                            Naam = "Wim"
                        });
                });

            modelBuilder.Entity("WC3Oef3.Models.Vak", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naam")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Naam")
                        .IsUnique()
                        .HasFilter("[Naam] IS NOT NULL");

                    b.ToTable("Vakken");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Naam = ".NET Essentials"
                        },
                        new
                        {
                            Id = 2,
                            Naam = ".NET Advanced"
                        },
                        new
                        {
                            Id = 3,
                            Naam = "Programming Essentials"
                        },
                        new
                        {
                            Id = 4,
                            Naam = "Programming Advanced"
                        },
                        new
                        {
                            Id = 5,
                            Naam = "Data Essentials"
                        },
                        new
                        {
                            Id = 6,
                            Naam = "Data Advanced"
                        });
                });

            modelBuilder.Entity("WC3Oef3.Models.Punt", b =>
                {
                    b.HasOne("WC3Oef3.Models.Student", "Student")
                        .WithMany("Punten")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WC3Oef3.Models.Vak", "Vak")
                        .WithMany()
                        .HasForeignKey("VakId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
