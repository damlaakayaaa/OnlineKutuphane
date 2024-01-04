﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebUygulamaProje1.Utility;

#nullable disable

namespace WebUygulamaProje1.Migrations
{
    [DbContext(typeof(UygulamaDbContext))]
    [Migration("20231023065838_KitapTurleriTablosuEkle")]
    partial class KitapTurleriTablosuEkle
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebUygulamaProje1.Models.KitapTuru", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("KitapTuruId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("KitapTuruId");

                    b.ToTable("KitapTurleri");
                });

            modelBuilder.Entity("WebUygulamaProje1.Models.KitapTuru", b =>
                {
                    b.HasOne("WebUygulamaProje1.Models.KitapTuru", null)
                        .WithMany("KitapTurleri")
                        .HasForeignKey("KitapTuruId");
                });

            modelBuilder.Entity("WebUygulamaProje1.Models.KitapTuru", b =>
                {
                    b.Navigation("KitapTurleri");
                });
#pragma warning restore 612, 618
        }
    }
}