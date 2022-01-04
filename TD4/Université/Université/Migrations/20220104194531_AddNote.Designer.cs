﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Université;

namespace Université.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220104194531_AddNote")]
    partial class AddNote
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Université.Entity.Enseignant", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Nom")
                        .HasColumnType("text");

                    b.Property<string>("Prenom")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("Enseignant");
                });

            modelBuilder.Entity("Université.Entity.Enseigner", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("LUEID")
                        .HasColumnType("integer");

                    b.Property<int>("LenseignantID")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.HasIndex("LUEID");

                    b.HasIndex("LenseignantID");

                    b.ToTable("Enseigner");
                });

            modelBuilder.Entity("Université.Entity.Etudiant", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("FormationSuivieID")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Naissance")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NumeroEtudiant")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.HasIndex("FormationSuivieID");

                    b.ToTable("Etudiant");
                });

            modelBuilder.Entity("Université.Entity.Etudier", b =>
                {
                    b.Property<int?>("LEtudiantID")
                        .HasColumnType("integer");

                    b.Property<int?>("LUEID")
                        .HasColumnType("integer");

                    b.HasKey("LEtudiantID", "LUEID");

                    b.HasIndex("LUEID");

                    b.ToTable("Etudier");
                });

            modelBuilder.Entity("Université.Entity.Formation", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("AnneDiplome")
                        .HasColumnType("integer");

                    b.Property<string>("Intitule")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("Formation");
                });

            modelBuilder.Entity("Université.Entity.Note", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("RelationEtudiantLEtudiantID")
                        .HasColumnType("integer");

                    b.Property<int?>("RelationEtudiantLUEID")
                        .HasColumnType("integer");

                    b.Property<float>("Valeur")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("RelationEtudiantLEtudiantID", "RelationEtudiantLUEID");

                    b.ToTable("Note");
                });

            modelBuilder.Entity("Université.Entity.UE", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("FormationID")
                        .HasColumnType("integer");

                    b.Property<string>("Intitule")
                        .HasColumnType("text");

                    b.Property<string>("Numero")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.HasIndex("FormationID");

                    b.ToTable("UE");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Université.Entity.Enseigner", b =>
                {
                    b.HasOne("Université.Entity.UE", "LUE")
                        .WithMany("LesEnseigner")
                        .HasForeignKey("LUEID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Université.Entity.Enseignant", "Lenseignant")
                        .WithMany("LesEnseigner")
                        .HasForeignKey("LenseignantID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lenseignant");

                    b.Navigation("LUE");
                });

            modelBuilder.Entity("Université.Entity.Etudiant", b =>
                {
                    b.HasOne("Université.Entity.Formation", "FormationSuivie")
                        .WithMany("EtudiantsInscrits")
                        .HasForeignKey("FormationSuivieID");

                    b.Navigation("FormationSuivie");
                });

            modelBuilder.Entity("Université.Entity.Etudier", b =>
                {
                    b.HasOne("Université.Entity.Etudiant", "LEtudiant")
                        .WithMany("MatiereInscrit")
                        .HasForeignKey("LEtudiantID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Université.Entity.UE", "LUE")
                        .WithMany("Effectif")
                        .HasForeignKey("LUEID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LEtudiant");

                    b.Navigation("LUE");
                });

            modelBuilder.Entity("Université.Entity.Note", b =>
                {
                    b.HasOne("Université.Entity.Etudier", "RelationEtudiant")
                        .WithMany()
                        .HasForeignKey("RelationEtudiantLEtudiantID", "RelationEtudiantLUEID");

                    b.Navigation("RelationEtudiant");
                });

            modelBuilder.Entity("Université.Entity.UE", b =>
                {
                    b.HasOne("Université.Entity.Formation", "Formation")
                        .WithMany("UEProposee")
                        .HasForeignKey("FormationID");

                    b.Navigation("Formation");
                });

            modelBuilder.Entity("Université.Entity.Enseignant", b =>
                {
                    b.Navigation("LesEnseigner");
                });

            modelBuilder.Entity("Université.Entity.Etudiant", b =>
                {
                    b.Navigation("MatiereInscrit");
                });

            modelBuilder.Entity("Université.Entity.Formation", b =>
                {
                    b.Navigation("EtudiantsInscrits");

                    b.Navigation("UEProposee");
                });

            modelBuilder.Entity("Université.Entity.UE", b =>
                {
                    b.Navigation("Effectif");

                    b.Navigation("LesEnseigner");
                });
#pragma warning restore 612, 618
        }
    }
}
