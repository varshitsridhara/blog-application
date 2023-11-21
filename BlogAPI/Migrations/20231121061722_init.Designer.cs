﻿// <auto-generated />
using System;
using BlogAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BlogAPI.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20231121061722_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("BlogAPI.Models.BlogModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Content")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("OwnerName")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<long?>("userId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("userId");

                    b.ToTable("Blogs");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Content = "This is my first blog",
                            CreatedAt = new DateTime(2023, 11, 21, 6, 17, 22, 784, DateTimeKind.Utc).AddTicks(5462),
                            Title = "First Blog",
                            UpdatedAt = new DateTime(2023, 11, 21, 6, 17, 22, 784, DateTimeKind.Utc).AddTicks(5465)
                        });
                });

            modelBuilder.Entity("BlogAPI.Models.User", b =>
                {
                    b.Property<long?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long?>("Id"));

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("UserName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Email = "Half@email.com",
                            Password = "Password",
                            UserName = "John Doe"
                        });
                });

            modelBuilder.Entity("BlogAPI.Models.BlogModel", b =>
                {
                    b.HasOne("BlogAPI.Models.User", "user")
                        .WithMany()
                        .HasForeignKey("userId");

                    b.Navigation("user");
                });
#pragma warning restore 612, 618
        }
    }
}