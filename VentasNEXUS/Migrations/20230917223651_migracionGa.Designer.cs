﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VentasNEXUS.Data;

namespace VentasNEXUS.Migrations
{
    [DbContext(typeof(VentasNEXUSContext))]
    [Migration("20230917223651_migracionGa")]
    partial class migracionGa
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VentasNEXUS.Models.Client", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Nit")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("VentasNEXUS.Models.Products", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<int?>("SalesID")
                        .HasColumnType("int");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("SalesID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("VentasNEXUS.Models.Sales", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Client_sID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("Client_sID");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("VentasNEXUS.Models.Products", b =>
                {
                    b.HasOne("VentasNEXUS.Models.Sales", null)
                        .WithMany("listaProductos_S")
                        .HasForeignKey("SalesID");
                });

            modelBuilder.Entity("VentasNEXUS.Models.Sales", b =>
                {
                    b.HasOne("VentasNEXUS.Models.Client", "Client_s")
                        .WithMany()
                        .HasForeignKey("Client_sID");

                    b.Navigation("Client_s");
                });

            modelBuilder.Entity("VentasNEXUS.Models.Sales", b =>
                {
                    b.Navigation("listaProductos_S");
                });
#pragma warning restore 612, 618
        }
    }
}
