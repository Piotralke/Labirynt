﻿// <auto-generated />
using LabiryntBackend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LabiryntBackend.Migrations
{
    [DbContext(typeof(GBMazeContext))]
    [Migration("20230420085659_fk")]
    partial class fk
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LabiryntBackend.Models.Maze", b =>
                {
                    b.Property<long>("id_maze")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("id_maze"));

                    b.Property<string>("codedMaze")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("height")
                        .HasColumnType("bigint");

                    b.Property<long>("id_user")
                        .HasColumnType("bigint");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("userid_user")
                        .HasColumnType("bigint");

                    b.Property<long>("width")
                        .HasColumnType("bigint");

                    b.HasKey("id_maze");

                    b.HasIndex("userid_user");

                    b.ToTable("Mazes");
                });

            modelBuilder.Entity("LabiryntBackend.Models.User", b =>
                {
                    b.Property<long>("id_user")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("id_user"));

                    b.Property<string>("login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_user");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("LabiryntBackend.Models.Maze", b =>
                {
                    b.HasOne("LabiryntBackend.Models.User", "user")
                        .WithMany()
                        .HasForeignKey("userid_user")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });
#pragma warning restore 612, 618
        }
    }
}
