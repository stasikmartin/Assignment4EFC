﻿// <auto-generated />
using AdultsWebApi.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AdultsWebApi.Migrations
{
    [DbContext(typeof(AdultsContext))]
    partial class AdultsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("AdultsWebApi.Model.Adult", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("eyeColor")
                        .HasColumnType("TEXT");

                    b.Property<string>("firstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("hairColor")
                        .HasColumnType("TEXT");

                    b.Property<double>("height")
                        .HasColumnType("REAL");

                    b.Property<string>("jobTitle")
                        .HasColumnType("TEXT");

                    b.Property<string>("lastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("sex")
                        .HasColumnType("TEXT");

                    b.Property<double>("weight")
                        .HasColumnType("REAL");

                    b.HasKey("id");

                    b.ToTable("adults");
                });
#pragma warning restore 612, 618
        }
    }
}
