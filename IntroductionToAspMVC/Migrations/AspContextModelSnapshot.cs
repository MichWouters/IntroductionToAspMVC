﻿// <auto-generated />
using System;
using IntroductionToAspMVC;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IntroductionToAspMVC.Migrations
{
    [DbContext(typeof(AspContext))]
    partial class AspContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IntroductionToAspMVC.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int>("Genre")
                        .HasColumnType("int");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2021, 5, 27, 10, 48, 4, 206, DateTimeKind.Local).AddTicks(4935),
                            Genre = 6,
                            Modified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Rating = 7.7999999999999998,
                            ReleaseDate = new DateTime(1993, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Jurassic Park"
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2021, 5, 27, 10, 48, 4, 208, DateTimeKind.Local).AddTicks(3918),
                            Genre = 2,
                            Modified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Rating = 7.5,
                            ReleaseDate = new DateTime(1991, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Terminator 2"
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(2021, 5, 27, 10, 48, 4, 208, DateTimeKind.Local).AddTicks(3944),
                            Genre = 7,
                            Modified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Rating = 7.7999999999999998,
                            ReleaseDate = new DateTime(1982, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Thing"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
