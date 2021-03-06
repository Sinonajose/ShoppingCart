﻿// <auto-generated />
using CartApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CartApi.Migrations
{
    [DbContext(typeof(ProductContext))]
    [Migration("20200512095426_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0-preview.3.20181.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CartApi.Models.Product", b =>
                {
                    b.Property<string>("PId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("price")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("product")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PId");

                    b.ToTable("Product");
                });
#pragma warning restore 612, 618
        }
    }
}
