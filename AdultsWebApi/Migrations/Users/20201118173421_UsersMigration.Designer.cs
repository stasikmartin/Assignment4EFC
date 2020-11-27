﻿// <auto-generated />
using AdultsWebApi.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AdultsWebApi.Migrations.Users
{
    [DbContext(typeof(UsersContext))]
    [Migration("20201118173421_UsersMigration")]
    partial class UsersMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("AdultsWebApi.Model.User", b =>
                {
                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.Property<int>("BirthYear")
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<string>("Domain")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<string>("Role")
                        .HasColumnType("TEXT");

                    b.Property<int>("SecurityLevel")
                        .HasColumnType("INTEGER");

                    b.HasKey("UserName");

                    b.ToTable("users");
                });
#pragma warning restore 612, 618
        }
    }
}
