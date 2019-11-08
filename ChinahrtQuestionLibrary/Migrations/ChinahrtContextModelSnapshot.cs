﻿// <auto-generated />
using System;
using ChinahrtQuestionLibrary.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ChinahrtQuestionLibrary.Migrations
{
    [DbContext(typeof(ChinahrtContext))]
    partial class ChinahrtContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ChinahrtQuestionLibrary.Models.Answer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsRight")
                        .HasColumnType("bit");

                    b.Property<Guid>("Question_Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Result")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.HasKey("Id");

                    b.HasIndex("Question_Id");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("ChinahrtQuestionLibrary.Models.Question", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.HasKey("Id");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("ChinahrtQuestionLibrary.Models.Answer", b =>
                {
                    b.HasOne("ChinahrtQuestionLibrary.Models.Question", null)
                        .WithMany("Answers")
                        .HasForeignKey("Question_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}