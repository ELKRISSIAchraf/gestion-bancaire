﻿// <auto-generated />
using System;
using GestionBancaireApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GestionBancaireApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230607150238_migration5")]
    partial class migration5
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("GestionBancaireApi.Models.Compte", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("Solde")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Comptes");
                });

            modelBuilder.Entity("GestionBancaireApi.Models.Mouvement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CompteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateMnt")
                        .HasColumnType("datetime(6)");

                    b.Property<decimal>("Montant")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CompteId");

                    b.ToTable("Mouvements");
                });

            modelBuilder.Entity("GestionBancaireApi.Models.Mouvement", b =>
                {
                    b.HasOne("GestionBancaireApi.Models.Compte", "Compte")
                        .WithMany("Mouvements")
                        .HasForeignKey("CompteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Compte");
                });

            modelBuilder.Entity("GestionBancaireApi.Models.Compte", b =>
                {
                    b.Navigation("Mouvements");
                });
#pragma warning restore 612, 618
        }
    }
}
