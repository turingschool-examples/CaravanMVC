﻿// <auto-generated />
using CaravanMVC.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CaravanMVC.Migrations
{
    [DbContext(typeof(CaravanMvcContext))]
    [Migration("20230821194800_CreateDb")]
    partial class CreateDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CaravanMVC.Models.Passenger", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("integer")
                        .HasColumnName("age");

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("destination");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<int>("WagonId")
                        .HasColumnType("integer")
                        .HasColumnName("wagon_id");

                    b.HasKey("Id")
                        .HasName("pk_passengers");

                    b.HasIndex("WagonId")
                        .HasDatabaseName("ix_passengers_wagon_id");

                    b.ToTable("passengers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 20,
                            Destination = "new york",
                            Name = "john doe",
                            WagonId = 1
                        },
                        new
                        {
                            Id = 2,
                            Age = 20,
                            Destination = "new york",
                            Name = "pam beasely",
                            WagonId = 1
                        },
                        new
                        {
                            Id = 3,
                            Age = 20,
                            Destination = "new york",
                            Name = "jim halpert",
                            WagonId = 1
                        },
                        new
                        {
                            Id = 4,
                            Age = 20,
                            Destination = "new york",
                            Name = "ryan howard",
                            WagonId = 2
                        },
                        new
                        {
                            Id = 5,
                            Age = 20,
                            Destination = "new york",
                            Name = "michael scott",
                            WagonId = 2
                        },
                        new
                        {
                            Id = 6,
                            Age = 20,
                            Destination = "new york",
                            Name = "dwight schrute",
                            WagonId = 2
                        });
                });

            modelBuilder.Entity("CaravanMVC.Models.Wagon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("Covered")
                        .HasColumnType("boolean")
                        .HasColumnName("covered");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<int>("NumWheels")
                        .HasColumnType("integer")
                        .HasColumnName("num_wheels");

                    b.HasKey("Id")
                        .HasName("pk_wagons");

                    b.ToTable("wagons", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Covered = true,
                            Name = "old faithful",
                            NumWheels = 4
                        },
                        new
                        {
                            Id = 2,
                            Covered = false,
                            Name = "unreliable",
                            NumWheels = 3
                        });
                });

            modelBuilder.Entity("CaravanMVC.Models.Passenger", b =>
                {
                    b.HasOne("CaravanMVC.Models.Wagon", "Wagon")
                        .WithMany("Passengers")
                        .HasForeignKey("WagonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_passengers_wagons_wagon_id");

                    b.Navigation("Wagon");
                });

            modelBuilder.Entity("CaravanMVC.Models.Wagon", b =>
                {
                    b.Navigation("Passengers");
                });
#pragma warning restore 612, 618
        }
    }
}
