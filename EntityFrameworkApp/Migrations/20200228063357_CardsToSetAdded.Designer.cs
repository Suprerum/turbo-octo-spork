﻿// <auto-generated />
using System;
using EntityFrameworkApp;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EntityFrameworkApp.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20200228063357_CardsToSetAdded")]
    partial class CardsToSetAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityFrameworkApp.Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("PainterId")
                        .HasColumnType("int");

                    b.Property<int>("SerialNumber")
                        .HasColumnType("int");

                    b.Property<int?>("SetId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PainterId");

                    b.HasIndex("SetId");

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("EntityFrameworkApp.Painter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Painters");
                });

            modelBuilder.Entity("EntityFrameworkApp.Set", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReleaseDate")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Sets");
                });

            modelBuilder.Entity("EntityFrameworkApp.Card", b =>
                {
                    b.HasOne("EntityFrameworkApp.Painter", "Painter")
                        .WithMany("Cards")
                        .HasForeignKey("PainterId");

                    b.HasOne("EntityFrameworkApp.Set", "Set")
                        .WithMany("Cards")
                        .HasForeignKey("SetId");
                });
#pragma warning restore 612, 618
        }
    }
}
