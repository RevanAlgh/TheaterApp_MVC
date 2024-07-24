﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TheatreApp.Web.Data;

#nullable disable

namespace TheatreApp.Web.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240724124114_AddeddefaultValues")]
    partial class AddeddefaultValues
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MovieApi.Models.Author", b =>
                {
                    b.Property<int>("AuthorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuthorID"));

                    b.Property<string>("AuthorName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("AuthorID");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("TheaterApp.Models.Movie", b =>
                {
                    b.Property<int>("MovieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MovieID"));

                    b.Property<int>("AuthorID")
                        .HasColumnType("int");

                    b.Property<decimal>("BoxOffice")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Budget")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<float>("ImdbRating")
                        .HasColumnType("real");

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("MovieTitle")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("YearReleased")
                        .HasColumnType("int");

                    b.HasKey("MovieID");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("TheaterApp.Models.MovieAuthor", b =>
                {
                    b.Property<int>("MovieID")
                        .HasColumnType("int");

                    b.Property<int>("AuthorID")
                        .HasColumnType("int");

                    b.HasKey("MovieID", "AuthorID");

                    b.HasIndex("AuthorID");

                    b.ToTable("MovieAuthors");
                });

            modelBuilder.Entity("TheaterApp.Models.MovieAuthor", b =>
                {
                    b.HasOne("MovieApi.Models.Author", "Author")
                        .WithMany("MovieAuthors")
                        .HasForeignKey("AuthorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TheaterApp.Models.Movie", "Movie")
                        .WithMany("MovieAuthors")
                        .HasForeignKey("MovieID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("MovieApi.Models.Author", b =>
                {
                    b.Navigation("MovieAuthors");
                });

            modelBuilder.Entity("TheaterApp.Models.Movie", b =>
                {
                    b.Navigation("MovieAuthors");
                });
#pragma warning restore 612, 618
        }
    }
}
