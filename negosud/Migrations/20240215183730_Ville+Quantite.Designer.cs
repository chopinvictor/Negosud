﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Negosud.Context;

#nullable disable

namespace Negosud.Migrations
{
    [DbContext(typeof(NegosudContext))]
    [Migration("20240215183730_Ville+Quantite")]
    partial class VilleQuantite
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CommandeProduit", b =>
                {
                    b.Property<int>("ListCommandesId")
                        .HasColumnType("int");

                    b.Property<int>("ListProduitsId")
                        .HasColumnType("int");

                    b.HasKey("ListCommandesId", "ListProduitsId");

                    b.HasIndex("ListProduitsId");

                    b.ToTable("CommandeProduit");
                });

            modelBuilder.Entity("Negosud.Class.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AdresseClient")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CodePostalClient")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("varchar(5)");

                    b.Property<string>("EmailClient")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.Property<string>("NomClient")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.Property<string>("PaysClient")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.Property<string>("PrenomClient")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.Property<string>("TelephoneClient")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("VilleClient")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Negosud.Class.Commande", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("ClientId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCommande")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("EstEntreeSortie")
                        .HasColumnType("tinyint(1)");

                    b.Property<int?>("FournisseurId")
                        .HasColumnType("int");

                    b.Property<double?>("PrixTotal")
                        .HasColumnType("double");

                    b.Property<int>("Remise")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Commandes");
                });

            modelBuilder.Entity("Negosud.Class.Domaine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AdresseDomaine")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CodePostalDomaine")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("NomDomaine")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.Property<string>("PaysDomaine")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.Property<string>("VilleDomaine")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Domaines");
                });

            modelBuilder.Entity("Negosud.Class.Fournisseur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AdresseFournisseur")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CodePostalFournisseur")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("EmailFournisseur")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.Property<string>("NomFournisseur")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.Property<string>("PaysFournisseur")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.Property<string>("TelephoneFournisseur")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("VilleFournisseur")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Fournisseurs");
                });

            modelBuilder.Entity("Negosud.Class.Historique", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DateD")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DateF")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("FournisseurId")
                        .HasColumnType("int");

                    b.Property<double>("PrixAchat")
                        .HasColumnType("double");

                    b.Property<int>("ProduitId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FournisseurId");

                    b.HasIndex("ProduitId");

                    b.ToTable("Historiques");
                });

            modelBuilder.Entity("Negosud.Class.Produit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("DomaineID")
                        .HasColumnType("int");

                    b.Property<int>("NbProduit")
                        .HasColumnType("int");

                    b.Property<string>("NomProduit")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.Property<double>("PrixProduit")
                        .HasColumnType("double");

                    b.Property<int>("Quantite")
                        .HasColumnType("int");

                    b.Property<int>("TypeID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DomaineID");

                    b.HasIndex("TypeID");

                    b.ToTable("Produits");
                });

            modelBuilder.Entity("Negosud.Class.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CommandeId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<int>("NbProduit")
                        .HasColumnType("int");

                    b.Property<double>("Prix")
                        .HasColumnType("double");

                    b.Property<int>("ProduitId")
                        .HasColumnType("int");

                    b.Property<int>("Remise")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CommandeId");

                    b.HasIndex("ProduitId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("Negosud.Class.Type", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NomType")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.HasKey("Id");

                    b.ToTable("Types");
                });

            modelBuilder.Entity("Negosud.Class.Utilisateur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Admin")
                        .HasMaxLength(80)
                        .HasColumnType("tinyint(80)");

                    b.Property<string>("MotDePasse")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.Property<string>("NomUtilisateur")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CommandeProduit", b =>
                {
                    b.HasOne("Negosud.Class.Commande", null)
                        .WithMany()
                        .HasForeignKey("ListCommandesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Negosud.Class.Produit", null)
                        .WithMany()
                        .HasForeignKey("ListProduitsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Negosud.Class.Historique", b =>
                {
                    b.HasOne("Negosud.Class.Fournisseur", null)
                        .WithMany("ListHistorique")
                        .HasForeignKey("FournisseurId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Negosud.Class.Produit", null)
                        .WithMany("ListHistorique")
                        .HasForeignKey("ProduitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Negosud.Class.Produit", b =>
                {
                    b.HasOne("Negosud.Class.Domaine", "Domaine")
                        .WithMany()
                        .HasForeignKey("DomaineID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Negosud.Class.Type", "Type")
                        .WithMany()
                        .HasForeignKey("TypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Domaine");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("Negosud.Class.Transaction", b =>
                {
                    b.HasOne("Negosud.Class.Commande", "Commande")
                        .WithMany()
                        .HasForeignKey("CommandeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Negosud.Class.Produit", "Produit")
                        .WithMany()
                        .HasForeignKey("ProduitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Commande");

                    b.Navigation("Produit");
                });

            modelBuilder.Entity("Negosud.Class.Fournisseur", b =>
                {
                    b.Navigation("ListHistorique");
                });

            modelBuilder.Entity("Negosud.Class.Produit", b =>
                {
                    b.Navigation("ListHistorique");
                });
#pragma warning restore 612, 618
        }
    }
}
