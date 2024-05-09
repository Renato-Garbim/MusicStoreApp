﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MusicStoreMVC.Contexto;

#nullable disable

namespace MusicStoreMVC.Migrations
{
    [DbContext(typeof(MusicStoreContext))]
    [Migration("20240509020424_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MusicStoreMVC.Entidades.Artista", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Artista");
                });

            modelBuilder.Entity("MusicStoreMVC.Entidades.CD", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Ano")
                        .HasColumnType("int");

                    b.Property<int>("GeneroId")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GeneroId");

                    b.ToTable("CD");
                });

            modelBuilder.Entity("MusicStoreMVC.Entidades.Genero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genero");
                });

            modelBuilder.Entity("MusicStoreMVC.Entidades.Musica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ArtistaId")
                        .HasColumnType("int");

                    b.Property<int?>("CDId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ArtistaId");

                    b.HasIndex("CDId");

                    b.ToTable("Musica");
                });

            modelBuilder.Entity("MusicStoreMVC.Entidades.CD", b =>
                {
                    b.HasOne("MusicStoreMVC.Entidades.Genero", "Genero")
                        .WithMany("CDs")
                        .HasForeignKey("GeneroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genero");
                });

            modelBuilder.Entity("MusicStoreMVC.Entidades.Musica", b =>
                {
                    b.HasOne("MusicStoreMVC.Entidades.Artista", "Artistas")
                        .WithMany("Musicas")
                        .HasForeignKey("ArtistaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MusicStoreMVC.Entidades.CD", null)
                        .WithMany("Musicas")
                        .HasForeignKey("CDId");

                    b.Navigation("Artistas");
                });

            modelBuilder.Entity("MusicStoreMVC.Entidades.Artista", b =>
                {
                    b.Navigation("Musicas");
                });

            modelBuilder.Entity("MusicStoreMVC.Entidades.CD", b =>
                {
                    b.Navigation("Musicas");
                });

            modelBuilder.Entity("MusicStoreMVC.Entidades.Genero", b =>
                {
                    b.Navigation("CDs");
                });
#pragma warning restore 612, 618
        }
    }
}
